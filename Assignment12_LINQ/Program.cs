
using System.Xml.Linq;

namespace Assignment12_LINQ

  
{
    internal class Program
    {
        static void Main()
        {

            // q1 : Restriction Operators

            #region p1: Find all products that are out of stock.

            //var products = ListGenerators.ProductList;

            //var outOfStockProducts = products.Where(p => p.UnitsInStock == 0);

            //foreach (var product in outOfStockProducts)
            //{
            //    Console.WriteLine($"{product.ProductName} is out of stock.");
            //}

            #endregion



            #region p2: Find all products that are in stock and cost more than 3.00 per unit.

            //List<Product> products = ListGenerators.ProductList;

            //var result = products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00m);

            //Console.WriteLine("Products in stock and cost more than $3.00:");

            //foreach (var product in result)
            //{
            //    Console.WriteLine($"- {product.ProductName}, Price: {product.UnitPrice:C}, Stock: {product.UnitsInStock}");
            //}

            #endregion



            #region p3:. Returns digits whose name is shorter than their value.


            //string[] digits = { "zero", "one", "two", "three", "four",
            //        "five", "six", "seven", "eight", "nine" };


            // var result = digits
            //.Select((name, index) => new { Name = name, Value = index })
            //.Where(d => d.Name.Length < d.Value);

            // foreach (var item in result)
            // {
            //     Console.WriteLine($"{item.Name} (value = {item.Value})");
            // }

            #endregion





            // q2 : Element Operators

            #region p1: Get first Product out of Stock 

            List<Product> products = ListGenerators.ProductList;
            var FristOutOfStock = products.FirstOrDefault(p => p.UnitsInStock == 0);
            if (FristOutOfStock != null)
            {
                Console.WriteLine($"First out of stock product: {FristOutOfStock.ProductName}");
            }
            else
            {
                Console.WriteLine("No products are out of stock.");
            }


            #endregion

        }
    }
}
