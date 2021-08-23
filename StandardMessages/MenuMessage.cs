using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShoppingApp
{
    public class MenuMessage
    {
        public static void DisplayMenuMessage()
        {
            Console.WriteLine("Current Date and Time\n{0}", DateTime.Now);
            Console.WriteLine("Menu");
            Console.WriteLine("a - Add item to cart");
            Console.WriteLine("r - Remove item from cart");
            Console.WriteLine("c - Change item quantity");
            Console.WriteLine("i - Output items' descriptions");
            Console.WriteLine("o - Output shopping cart");
            Console.WriteLine("q - Quit");
            Console.WriteLine("Choose an option:");
        }
    }
}
