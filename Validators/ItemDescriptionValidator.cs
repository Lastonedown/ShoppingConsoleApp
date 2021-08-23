using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShoppingApp
{
    public class ItemDescriptionValidator
    {
        public static string Validate()
        {
            string itemDescription = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(itemDescription))
            {
                EnterItemDescriptionMessage.DisplayEnterItemDescriptionMessage();
                itemDescription = Console.ReadLine();
            }

            return itemDescription;
        }
    }
}
