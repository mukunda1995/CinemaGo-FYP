using CinemaGo.DataModels.CustomModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaGo.Logic.Services
{
    public interface IAdminService
    {
        ResponseModel AdminLogin(LoginModel loginModel);
        CinemaModel SaveCinema(CinemaModel addCinemaModel);
        List<CinemaModel> GetCinemas();
        bool UpdateCinema(CinemaModel cinemaToUpdate);
        bool DeleteCinema(CinemaModel cinemaToDelete);
        CategoryModel SaveCategory(CategoryModel newCategory);
        List<CategoryModel> GetCategories();
        bool UpdateCategory(CategoryModel categoryToUpdate);
        bool DeleteCategory(CategoryModel categoryToDelete);
        List<ProductModel> GetProducts();
        bool DeleteProduct(ProductModel productToDelete);
        int GetNewProductId();
        ProductModel SaveProduct(ProductModel newProduct);
        List<StockModel> GetProductStock();
        bool UpdateProductStock(StockModel stock);
        
        
    }
}
