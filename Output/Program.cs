using DataAccessLayer;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using Microsoft.Identity.Client;

namespace Output
{
    public class Program
    {
        static QuickKartDbContext context;
        static QuickKartRepository repository;

        static Program()
        {
            context = new QuickKartDbContext();
            repository = new QuickKartRepository(context);
               
        
        }

        static void Main(string[] args)
        {

            #region Read Methods

            #region get all category

            var categories = repository.GetAllCategries();

            foreach (var category in categories)
            {

                Console.WriteLine("{0}\t\t\t{1}", category.CategoryId, category.CategoryName);

            }
            #endregion

            #region Get all product by category id 

            //byte categoryid = 1;

            //var listproduct = repository.getallproductbyid(categoryid); 
            //if(listproduct.count == 0) {

            //    console.writeline("product products available under this categoryid= " + categoryid);

            //}
            //else
            //{
            //    console.writeline("{0,-15}{1,-30}{2,-15}{3,-10}{4}", "productid", "productname", "categoryid", "price", "quantityavailable");

            //    console.writeline("================================================================================");

            //    foreach (var product in listproduct)
            //    {
            //        console.writeline("{0,-15}{1,-30}{2,-15}{3,-10}{4}", product.productid, product.productname, product.categoryid, product.price, product.quantityavailable);

            //    }
            //}
            #endregion

            #region filter proudct frist and last default method

            //byte categoryId = 1;

            //Product product = repository.filterProudct(categoryId);    

            //if(product == null)
            //{
            //    Console.WriteLine("Not Available");

            //}

            //else
            //{
            //    Console.WriteLine("{0,-15}{1,-30}{2,-15}{3,-10}{4}", "ProductId", "ProductName", "CategoryId", "Price", "QuantityAvailable");
            //    Console.WriteLine("---------------------------------------------------------------------------------------");
            //    Console.WriteLine("{0,-15}{1,-30}{2,-15}{3,-10}{4}", product.ProductId, product.ProductName, product.CategoryId, product.Price, product.QuantityAvailable);
            //}

            #endregion

            #region filter proudct usimg like by patterm

            //string pattern = "B%";

            //List<Product> ListProduct = repository.FilterProduct(pattern);

            //if (ListProduct.Count == 0)
            //{
            //    Console.WriteLine("No products available with the = " + pattern);
            //}
            //else
            //{
            //    Console.WriteLine("{0,-15}{1,-30}{2,-15}{3,-10}{4}", "ProductId", "ProductName", "CategoryId", "Price", "QuantityAvailable");
            //    Console.WriteLine("---------------------------------------------------------------------------------------");
            //    foreach (var product in ListProduct)
            //    {
            //        Console.WriteLine("{0,-15}{1,-30}{2,-15}{3,-10}{4}", product.ProductId, product.ProductName, product.CategoryId, product.Price, product.QuantityAvailable);
            //    }
            //}

            #endregion

            #endregion

            #region add Method

            #region Add one catergory
            //bool result = repository.AddProduct("Books");
            //if (result)
            //{

            //    Console.WriteLine("Done");

            //}
            //else
            //{
            //    Console.WriteLine("Not Done");
            //}

            #endregion


            #region Add Multiple product using reference


            //Product productOne = new Product();

            //productOne.ProductId = "P160";
            //productOne.ProductName = "The ";
            //productOne.CategoryId = 8;
            //productOne.Price = 450;
            //productOne.QuantityAvailable = 10;
            //Product productTwo = new Product();
            //productTwo.ProductId = "P161";
            //productTwo.ProductName = "101 hymes";
            //productTwo.CategoryId = 8;
            //productTwo.Price = 700;
            //productTwo.QuantityAvailable = 10;

            //bool result = repository.AddProductUsingAddRange(productOne, productTwo);

            //if (result) { Console.WriteLine("Done"); }

            //else { Console.WriteLine("Not Done"); }


            #endregion



            #endregion

            #region Update Method 

            #region update using find method

            //bool result = repository.updateCategory(8, "Games");

            //if(result)
            //{

            //    Console.WriteLine("Updated Successfully");
            //}
            //else
            //{
            //    Console.WriteLine("Try Again");
            //}


            #endregion

            #region update uisng upadte method 

            //bool result = repository.updateProuct("P160",3);

            //if (result)
            //{

            //    Console.WriteLine("Updated Successfully");
            //}
            //else
            //{
            //    Console.WriteLine("Try Again");
            //}
            #endregion

            #region update using udpate Range method

            //bool res = repository.updateRangeMethod(1, 0);

            //if(res)
            //{
            //    Console.WriteLine("Updated");
            //}
            //else
            //{
            //    Console.WriteLine( "Try Again" );
            //}



            #endregion



            #endregion

            #region Delete Method 

            #region Delete product using remove

            //bool res = repository.deleteproduct("P160");

            //if (res)
            //{

            //    Console.WriteLine("Deleted Successfully");
            //}
            //else
            //{
            //    Console.WriteLine("Try Again");
            //}

            #endregion

            #region Delete product delete range

            //bool res = repository.deleteUsingRange("Lam");

            //if (res)
            //{


            //    Console.WriteLine("Deleted Successfully");
            //}

            //else
            //{
            //    Console.WriteLine("Try Again");
            //}


            #endregion

            #endregion



        }
    }
}
