using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace DataAccessLayer
{
    public class QuickKartRepository
    {
        private QuickKartDbContext context;

       public QuickKartRepository(QuickKartDbContext context)
        {
            this.context = context; 
        }

        #region Read Methods

        #region Get All Categories 
        public List<Category> GetAllCategries()
        {
            //var categoriesList = (from c in context.Categories orderby c.CategoryId select c).ToList();// LINQ query syntax

            var categoriesList = context.Categories.OrderBy(C => C.CategoryId).ToList();  //  LINQ method syntax

            return categoriesList;

        }
        #endregion

        #region Get All Product by ID

        //public List<Product> GetAllProductById(byte categoryId)
        //{
        //    List<Product> ListProduct = new List<Product>();

        //    try
        //    {
        //        //ListProduct = (from p in context.Products where p.CategoryId == categoryId select p).ToList();

        //        ListProduct = context.Products.Where(p=>p.CategoryId==categoryId).ToList();  

        //    }
        //    catch (Exception)
        //    {

        //        ListProduct = null;
        //    }

        //    return ListProduct;

        //}


        #endregion

        #region Filter product by first and Default 

        //public Product FilterProducts(byte categoryId) {

        //  Product product = new Product();  
        //    try
        //    {

        //        product = (from p in context.Products where p.CategoryId == categoryId select p).FirstOrDefault();

        //    }
        //    catch (Exception)
        //    {

        //        product=null;
        //    }

        //    return product;


        //}



        #endregion

        #region FIlter prouduct by Last and Default Method

        //public Product filterProudct(byte categoryId)
        //{
        //    Product product = new Product(); 
        //    try
        //    {
        //        //product = (from p in context.Products where p.CategoryId == categoryId orderby p.Price descending select p).LastOrDefault();

        //        product = context.Products.Where(p.CategoryId == categoryId).OrderByDescending(p => p.Price).LastOrDefault();
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //    return product; 

        //}

        #endregion

        #region Flter product by pattern

        //public List<Product> FilterProduct(string pattern)
        //{

        //    List<Product> products = new List<Product>();

        //    try
        //    {
        //        products = (from p in context.Products where EF.Functions.Like(p.ProductName, pattern) select p).ToList();

        //        products = context.Products.Where(EF.Functions.Like(p.ProductName, pattern)).TOList();  
        //    }
        //    catch (Exception)
        //    {

        //        products = null;
        //    }

        //    return products;
        //}

        #endregion

        #endregion

        #region Create Method

        #region Add one catergory

        public bool AddProduct(string categoryName)
        {
            bool status = false;

           Category category = new Category();

            category.CategoryName=categoryName;

            try
            {
                context.Categories.Add(category);
                context.SaveChanges();
                status=true;

            }
            catch (Exception)
            {

                status = false; 
            }

            return status;

        }


        #endregion


        #region Add Multiple product using reference


        //public bool AddProductUsingAddRange(params Product[] products)
        //{
        //    bool status = false;
        //    try
        //    {
        //        context.Products.AddRange(products);
        //        context.SaveChanges();
        //        status = true;

        //    }
        //    catch (Exception)
        //    {

        //        status=false;
        //    }
        //    return status;
        //}

        #endregion

        #endregion

        #region Update Method 

        #region update using find method 

        //public bool updateCategory(byte categoryId , string categoryName)
        //{
        //    bool status=false;

        //    Category category = context.Categories.Find(categoryId);

        //    try
        //    {
        //        if(category != null) {

        //            category.CategoryName=categoryName; 
        //            context.SaveChanges();  
        //            status=true;


        //        }

        //        else
        //        {
        //            status = false;
        //        }

        //    }
        //    catch (Exception)
        //    {

        //        status = false;
        //    }
        //    return status;

        //}


        #endregion



        #region Update using udpate method

        //public bool updateProuct(string productId, decimal price)
        //{
        //    bool status=false;

        //    try
        //    {
        //       Product product = context.Products.Find(productId);
        //       product.Price=price;

        //        using(var newcontext=new QuickKartDbContext())
        //        {
        //       newcontext.Update(product);
        //        context.SaveChanges();
        //        status=true;
        //         }

        //    }
        //    catch (Exception)
        //    {

        //        status = false;
        //    }



        //        return status;
        //}


        #endregion


        #region using udpate Range method

        //public bool updateRangeMethod(byte categoryId  , int quntity)
        //{
        //    bool status = false;

        //    try
        //    {
        //        List<Product>products=context.Products.Where(p=>p.CategoryId==categoryId).ToList();

        //        foreach (var item in products)
        //        {
        //            item.QuantityAvailable += quntity;

        //        }

        //        using(var newcontext= new QuickKartDbContext())
        //        {
        //            newcontext.UpdateRange(products);
        //            newcontext.SaveChanges();  
        //            status=true;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        status = true;
        //    }

        //    return status;
        //}


        #endregion


        #endregion

        #region Delete Method

        #region Delete product using remove


        //public bool deleteproduct(string productId)

        //{

        //    bool status = false;

        //    try
        //    {
        //        Product product = context.Products.Find(productId);

        //        if (product != null)
        //        {

        //            context.Products.Remove(product);
        //            context.SaveChanges();
        //            status = true;

        //        }

        //    }
        //    catch (Exception)
        //    {

        //        status = false;

        //    }

        //    return status;



        //}

        #endregion

        #region Delete product delete range

        //public bool deleteUsingRange(string subString)
        //{
        //    bool status = false;

           
        //    try
        //    {
        //        var deleteProducts = context.Products.Where(p => p.ProductName.Contains(subString));
        //        context.Products.RemoveRange(deleteProducts);
        //        context.SaveChanges();
        //        status = true;
              
        //    }
        //    catch (Exception)
        //    {

        //        status = false;
        //    }

        //    return status;
        //}


        #endregion


        #endregion


    }
}

