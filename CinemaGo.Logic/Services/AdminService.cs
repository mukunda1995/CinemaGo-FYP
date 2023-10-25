using CinemaGo.DataModels.CustomModels;
using CinemaGo.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaGo.Logic.Services
{
    public class AdminService : IAdminService
    {
        private readonly CinemaGoDBContext _dBContext = null;

        public AdminService(CinemaGoDBContext appDbContext)
        {

            this._dBContext = appDbContext;
        }
        public ResponseModel AdminLogin(LoginModel loginModel)
        {
            ResponseModel response = new ResponseModel();

            try
            {
                var userData = _dBContext.AdminInfos.Where(x => x.Email == loginModel.EmailId).FirstOrDefault();
                if (userData != null)
                {
                    if (userData.Password == loginModel.Password)
                    {
                        response.Status = true;
                        response.Message = Convert.ToString(userData.Id) + "|" + userData.Name + "|" + userData.Email;

                    }
                    else
                    {
                        response.Status = false;
                        response.Message = "Your Password Is Incorrect";
                    }
                }
                else
                {
                    response.Status = false;
                    response.Message = "Email not registered. Please cheack Email Id";
                }

                return response;

            }
            catch (Exception ex)
            {
                response.Status = false;
                response.Message = "An Error has occurred. Please try again!";

                return response;

            }

        }

        public CategoryModel SaveCategory(CategoryModel newCategory)
        {
            try
            {
                Category _category = new Category();
                _category.Name = newCategory.Name;
                _dBContext.Add(_category);
                _dBContext.SaveChanges();
                return newCategory;
            }
            catch (Exception ex)
            {
                throw;
            }
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

        public bool UpdateCategory(CategoryModel categoryToUpdate)
        {
            bool flag = false;
            var _category = _dBContext.Categories.Where(x => x.Id == categoryToUpdate.Id).First();
            if (_category != null) 
            {
                _category.Name = categoryToUpdate.Name;
                _dBContext.Categories.Update(_category);
                _dBContext.SaveChanges();
                flag = true;
            }
            return flag;
        }

        public bool DeleteCategory(CategoryModel categoryToDelete) 
        {
            bool flag =false;
            var _category = _dBContext.Categories.Where(x => x.Id == categoryToDelete.Id).First();
            if(_category != null) 
            {
                _dBContext.Categories.Remove(_category);
                _dBContext.SaveChanges();
                flag = true;
            }
            return flag;
        }

        public List<ProductModel> GetProducts()
        {
            List<Category> categoryData = _dBContext.Categories.ToList();
            List<Product> productData = _dBContext.Products.ToList();
            List<ProductModel> _productList = new List<ProductModel>();
            foreach (var p in productData)
            {
                ProductModel _productModel = new ProductModel();
                _productModel.Id = p.Id;
                _productModel.Name = p.Name;
                _productModel.Price = p.Price;
                _productModel.Stock = p.Stock;
                _productModel.ImageUrl = p.ImageUrl;
                _productModel.CategoryId = p.CategoryId;
                _productModel.CategoryName = categoryData.Where(x => x.Id == p.CategoryId).Select(x => x.Name).FirstOrDefault();
                _productList.Add(_productModel);
            }
            return _productList;
        }

        public bool DeleteProduct(ProductModel productToDelete)
        {
            bool flag = false;
            var _product = _dBContext.Products.Where(x => x.Id == productToDelete.Id).FirstOrDefault();
            if (_product != null)
            {
                _dBContext.Products.Remove(_product);
                _dBContext.SaveChanges();
                flag = true;
            }
            return flag;
        }

        public int GetNewProductId() 
        {
            try
            {
                int nextProductId = _dBContext.Products.ToList().OrderByDescending(x => x.Id).Select(x => x.Id).FirstOrDefault();
                return nextProductId;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public ProductModel SaveProduct(ProductModel newProduct) 
        {
            try
            {
                Product _product = new Product();
                _product.Name = newProduct.Name;
                _product.Price = newProduct.Price;
                _product.ImageUrl = newProduct.ImageUrl;
                _product.CategoryId = newProduct.CategoryId;
                _product.Stock = newProduct.Stock;
                _dBContext.Add(_product);
                _dBContext.SaveChanges();
                return newProduct;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<StockModel> GetProductStock()
        {
            List<StockModel> productStock = new List<StockModel>();
            List<Category> categoryData = _dBContext.Categories.ToList();
            List<Product> productData = _dBContext.Products.ToList();
            foreach (var p in productData)
            {
                StockModel _productModel = new StockModel();
                _productModel.Id = p.Id;
                _productModel.Name = p.Name;
                _productModel.Stock = p.Stock;
                _productModel.CategoryName = categoryData.Where(x => x.Id == p.CategoryId).Select(x => x.Name).First();
                productStock.Add(_productModel);
            }
            return productStock;
        }

        public bool UpdateProductStock(StockModel stock) 
        {
            bool flag = false;
            var _product = _dBContext.Products.Where(x => x.Id == stock.Id).First();
            if (_product != null)
            {
                _product.Stock = stock.Stock + stock.NewStock;
                _dBContext.Products.Update(_product);
                _dBContext.SaveChanges();
                flag = true;
            }
            return flag;
        }
    }
}

