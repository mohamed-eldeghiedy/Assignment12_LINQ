
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

            //List<Product> products = ListGenerators.ProductList;
            //var FristOutOfStock = products.FirstOrDefault(p => p.UnitsInStock == 0);
            //if (FristOutOfStock != null)
            //{
            //    Console.WriteLine($"First out of stock product: {FristOutOfStock.ProductName}");
            //}
            //else
            //{
            //    Console.WriteLine("No products are out of stock.");
            //}


            #endregion



            #region p2:2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.


            //var expensiveProduct = ListGenerators.ProductList
            //    .FirstOrDefault(p => p.UnitPrice > 1000);

            //if (expensiveProduct != null)
            //{
            //    Console.WriteLine($"Product over $1000: {expensiveProduct.ProductName}, Price: {expensiveProduct.UnitPrice:C}");
            //}
            //else
            //{
            //    Console.WriteLine("No product found with price over $1000.");
            //}

            #endregion


            #region p3:  Retrieve the second number greater than 5

            int[] Numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int? secondGreaterThanFive = Numbers
                .Where(n => n > 5)
                .Skip(1)
                .FirstOrDefault();

            if (secondGreaterThanFive != 0)
            {
                Console.WriteLine($"Second number greater than 5 is: {secondGreaterThanFive}");
            }
            else
            {
                Console.WriteLine("No second number greater than 5 found.");
            }

            #endregion

        }
    }
}
