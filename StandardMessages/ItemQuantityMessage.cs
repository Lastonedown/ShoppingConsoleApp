using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShoppingApp
{
   public class ItemQuantityMessage
    {
        public static void DisplayEnterItemQtyMessage()
        {
            Console.WriteLine("Enter item quantity:");
        }

        public static void DisplayEnterValidQuantityMessage()
        {
            Console.WriteLine("Please enter valid item quantity:");
        }

        public static void DisplayQuantityUpdated()
        {
            Console.WriteLine("Item quantity successfully updated");
        }
    }
}
