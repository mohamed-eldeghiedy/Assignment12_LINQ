
using System.Xml.Linq;

namespace Assignment12_LINQ

  
{
    internal class Program
    {
        static void Main()
        {

            // q1 : Restriction Operators

            #region p1: Find all products that are out of stock.

            var products = ListGenerators.ProductList;

            var outOfStockProducts = products.Where(p => p.UnitsInStock == 0);

            foreach (var product in outOfStockProducts)
            {
                Console.WriteLine($"{product.ProductName} is out of stock.");
            }

            #endregion

        }
    }
}
