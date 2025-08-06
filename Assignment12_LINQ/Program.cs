
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

            List<Product> products = ListGenerators.ProductList;

            var result = products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00m);

            Console.WriteLine("Products in stock and cost more than $3.00:");

            foreach (var product in result)
            {
                Console.WriteLine($"- {product.ProductName}, Price: {product.UnitPrice:C}, Stock: {product.UnitsInStock}");
            }

            #endregion

        }
    }
}
