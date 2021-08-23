using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShoppingApp
{
    public class ItemPriceValidator
    {
        public static double Validate()
        {
            double parsedItemPrice;

            string itemPrice = Console.ReadLine();

            while (!double.TryParse(itemPrice, out parsedItemPrice))
            {
                ItemQuantityMessage.DisplayEnterValidQuantityMessage();
                itemPrice = Console.ReadLine();
            }

            return parsedItemPrice;


        }
    }
}
   
