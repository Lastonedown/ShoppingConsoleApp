using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShoppingApp
{
    public class ItemQuantityValidator
    {
        public static int Validate()
        {
            int parsedItemQuantity;

            string itemQuantity = Console.ReadLine();

            while (!Int32.TryParse(itemQuantity, out parsedItemQuantity))
            {
                ItemQuantityMessage.DisplayEnterValidQuantityMessage();
                itemQuantity = Console.ReadLine();
            }

            return parsedItemQuantity;



        }
    }
}
