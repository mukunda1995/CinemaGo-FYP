using CinemaGo.DataModels.CustomModels;
using CinemaGo.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stripe;
using System.Threading.Tasks;
using CinemaGo.Logic.Paypal;
using Microsoft.Extensions.Configuration;

namespace CinemaGo.Logic.Services
{
    public class UserService : IUserService
    {
        private readonly CinemaGoDBContext _dBContext = null;

        public IConfiguration _configuration { get; }

        public UserService(CinemaGoDBContext appDbContext, IConfiguration configuration)
        {

            this._dBContext = appDbContext;
            this._configuration = configuration;
        }
        public List<CategoryModel> GetCategories()
        {
            var data = _dBContext.Categories.ToList();
            List<CategoryModel> _categoryList = new List<CategoryModel>();
            foreach (var c in data)
            {
                CategoryModel _categoryModel = new CategoryModel();
                _categoryModel.Id = c.Id;
                _categoryModel.Name = c.Name;
                _categoryList.Add(_categoryModel);
            }
            return _categoryList;
        }

        public List<CinemaModel> GetCinemas()
        {
            var data = _dBContext.Cinemas.ToList();
            List<CinemaModel> _cinemaList = new List<CinemaModel>();
            foreach (var c in data)
            {
                CinemaModel _cinemaModel = new CinemaModel();
                _cinemaModel.Id = c.Id;
                _cinemaModel.Name = c.Name;
                _cinemaList.Add(_cinemaModel);
            }
            return _cinemaList;
        }

        public List<ProductModel> GetProductByCategoryId(int categoryId) 
        {
            var data = _dBContext.Products.Where(x => x.CategoryId == categoryId).ToList();
            
            List<ProductModel> _productList = new List<ProductModel>();
            foreach (var p in data) 
            {
                ProductModel _productModel = new ProductModel();

                _productModel.Id = p.Id;

                _productModel.Name =p.Name;

                _productModel.Price = p.Price;

                _productModel.ImageUrl = p.ImageUrl;

                _productModel.Stock = p.Stock;

                _productModel.CinemaId = p.CinemaId;

                _productList.Add(_productModel);
            }
            return _productList;
        }

        public ResponseModel RegisterUser(RegisterModel registerModel) 
        {
            ResponseModel response = new ResponseModel();
            try 
            {

                var exist_check = _dBContext.Customers.Where(x => x.Email == registerModel.EmailId).Any();
                if (!exist_check) 
                {
                    CinemaGo.DataModels.Models.Customer _customer = new CinemaGo.DataModels.Models.Customer();
                    _customer.Name =registerModel.Name;
                    _customer.MobileNo = registerModel.MobileNo;
                    _customer.Email= registerModel.EmailId;
                    _customer.Password= registerModel.Password;
                    _dBContext.Add(_customer);
                    _dBContext .SaveChanges();

                    LoginModel loginModel = new LoginModel()
                    {
                        EmailId = registerModel.EmailId,
                        Password = registerModel.Password
                    };

                    response = LoginUser(loginModel);
                }
                else 
                {
                    response.Status =false;

                    response.Message = "Email already registered.";
                }
                return response;
            }
            catch (Exception ex) 
            {
                response.Status = false;
                response.Message = "An Error hs occured. Try again!";

                return response;
            }
        }

        public ResponseModel LoginUser(LoginModel loginModel) 
        {
            ResponseModel response = new ResponseModel();

            try 
            {
                var userData = _dBContext.Customers.Where(x => x.Email == loginModel.EmailId).FirstOrDefault();
                if(userData != null) 
                {
                    if (userData.Password == loginModel.Password) 
                    {
                        response.Status = true;
                        response.Message = Convert.ToString(userData.Id) + "|" + userData.Name + "|" + userData.Email;
                    }
                    else 
                    {
                        response.Status = false;

                        response.Message = "Your Password is Incorrect";
                    }
                }
                else 
                {
                    response.Status = false;

                    response.Message = "Email not registered. Please check your Email Id";
                }

                return response;
            }
            catch (Exception ex) 
            {
                response.Status = false;
                response.Message = "An Error has occured. Please Try Again !!";

                return response;
            }
        }

        public ResponseModel Checkout(List<CartModel> cartItems) 
        {
            string OrderId = GenerateOrderId(); 
            var prods = _dBContext.Products.ToList();

            try 
            {
                var detail= cartItems.FirstOrDefault();
                CustomerOrder _customerOrder = new CustomerOrder();
                _customerOrder.CustomerId = detail.UserId;
                _customerOrder.OrderId= OrderId;
                _customerOrder.PaymentMode= detail.PaymentMode;
                _customerOrder.ShippingAddress = detail.ShippingAddress;
                _customerOrder.ShippingCharges =detail.ShippingCharges;
                _customerOrder.SubTotal =detail.SubTotal;
                _customerOrder.Total= detail.ShippingCharges + detail.SubTotal;
                _customerOrder.CreatedOn = DateTime.Now.ToString("dd/MM/yyyy");
                _customerOrder.UpdatedOn = DateTime.Now.ToString("dd/MM/yyyy");
                _dBContext.CustomerOrders.Add(_customerOrder);

                foreach  (var items in cartItems) 
                {
                    OrderDetail _orderDetail = new OrderDetail();
                    _orderDetail.OrderId = OrderId;
                    _orderDetail.ProductId = items.ProductId;
                    _orderDetail.Quantity = items.Quantity;
                    _orderDetail.Price =items.Price;
                    _orderDetail.SubTotal = items.Price* items.Quantity;
                    _orderDetail.CreatedOn = DateTime.Now.ToString("dd/MM/yyyy");
                    _orderDetail.UpdatedOn = DateTime.Now.ToString("dd/MM/yyyy");
                    _dBContext.OrderDetails.Add(_orderDetail);

                    var selected_product =prods.Where(x => x.Id == items.ProductId).FirstOrDefault();
                    selected_product.Stock = selected_product.Stock -items.Quantity; 
                    _dBContext.Products.Update(selected_product);    

                }

                _dBContext.SaveChanges();
                ResponseModel response = new ResponseModel();
                response.Message = OrderId;
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string GenerateOrderId() 
        {
            string OrderId = string.Empty;
            Random generator = null;
            for (int i= 0; i<1000; i++) 
            {
                generator = new Random();
                OrderId = "P" + generator.Next(1, 10000000).ToString("D8");
                if (!_dBContext.CustomerOrders.Where(x => x.OrderId == OrderId).Any()) 
                {
                    break;
                }
            }
            return OrderId;
        }

        public List<CustomerOrder> GetOrdersByCustomerId(int customerId) 
        {
            var _customerOrders = _dBContext.CustomerOrders.Where(x => x.CustomerId == customerId).OrderByDescending(x => x.Id).ToList();
            return _customerOrders;
        }

        public List<CartModel> GetOrderDetailForCustomer(int customerId, string order_number) 
        {
            List<CartModel> cart_details = new List<CartModel>();

            var customer_order = _dBContext.CustomerOrders.Where(x => x.CustomerId == customerId && x.OrderId == order_number).FirstOrDefault();

            if(customer_order != null) 
            {
                var order_detail = _dBContext.OrderDetails.Where(x => x.OrderId == order_number).ToList();
                var product_list = _dBContext.Products.ToList();

                foreach (var order in order_detail)
                {
                    var prod = product_list.Where(x => x.Id == order.ProductId).FirstOrDefault();
                    CartModel _cartModel = new CartModel();
                    _cartModel.ProductName=prod.Name;
                    _cartModel.Price=Convert.ToInt32(order.Price);
                    _cartModel.ProductImage=prod.ImageUrl;
                    _cartModel.Quantity=Convert.ToInt32(order.Quantity);
                    cart_details.Add(_cartModel);
                }

                cart_details.FirstOrDefault().ShippingAddress = customer_order.ShippingAddress;
                cart_details.FirstOrDefault().ShippingCharges = Convert.ToInt32(customer_order.ShippingCharges);
                cart_details.FirstOrDefault().SubTotal = Convert.ToInt32(customer_order.SubTotal);
                cart_details.FirstOrDefault().Total = Convert.ToInt32(customer_order.Total);
                cart_details.FirstOrDefault().PaymentMode = customer_order.PaymentMode;
            }

            return cart_details;
        }

        public ResponseModel ChangePassword(PasswordModel passwordModel)
        {
            ResponseModel response = new ResponseModel();
            response.Status = true;

            var _customer = _dBContext.Customers.Where(x => x.Id == passwordModel.UserKey).FirstOrDefault();
            if(_customer != null)
            {
                _customer.Password=passwordModel.Password;

                _dBContext.Customers.Update(_customer);

                _dBContext.SaveChanges();

                response.Message = "Password updated succesfuly !!";
            }
            else 
            {
                response.Message = "User does not exist.Try again !!";
            }
            return response;
        }

        public List<string> GetShippingStatusForOrder(string order_number) 
        {
            List<string> shipping_status = new List<string>();
            var order = _dBContext.CustomerOrders.Where(x => x.OrderId == order_number).FirstOrDefault();
            if (order != null && order.ShippingStatus != null) 
            {
                shipping_status = order.ShippingStatus.Split("|").ToList();
            }
            return shipping_status;
        }

        public async Task<string> MakePaymentStripe(string cardNumber,int expMonth,int expYear,string cvc,decimal value) 
        {
            try 
            {
                string response = string.Empty;
                StripeConfiguration.ApiKey = "sk_test_51O4MSzA3kfK3q8ubxRnFN7HdNpf97oVSIctWkeT7jYOqP229mzFfojQrBWncU30qNFcqM37A3HDe2jEqrNGpIXJ900Ma4obfwI";
                var optionToken = new TokenCreateOptions
                {
                    Card = new TokenCardOptions
                    {
                        Number = cardNumber,
                        ExpMonth = expMonth,
                        ExpYear = expYear,
                        Cvc = cvc
                    }
                };

                var serviceToken = new TokenService();
                Token stripetoken = await serviceToken.CreateAsync(optionToken);

                var customer = new Stripe.Customer
                {
                    Name = "Jackson",
                    Address = new Address
                    {
                        Country = "Malaysia",
                        City = "Penang",
                        Line1 = "37,TamanBukit,Penang",
                        PostalCode = "14000",
                    }
                };

                var options = new ChargeCreateOptions()
                {
                    Amount = Convert.ToInt32(value),

                    Currency = "MYR",

                    Description = "Test",

                    Source = stripetoken.Id,
                };

                var service = new ChargeService();
                Charge charge = await service.CreateAsync(options);

                if (charge.Paid) 
                {
                    response= "Success"+ "=" + charge.BalanceTransactionId;
                }
                else 
                {
                    response= "Fail";
                }
                return response;

            }
            catch(Exception ex) 
            {
                throw ex;
            }
        }

        public async Task<string> MakePaymentPaypal(double total) 
        {
            try 
            {
                var payPalAPI = new PayPalAPI(_configuration);
                string url = await payPalAPI.getRedirectURLToPayPal(total, "MYR");
                return url;
            }
            catch(Exception ex) 
            {
                return ex.Message;
            }
        }

    }
}
