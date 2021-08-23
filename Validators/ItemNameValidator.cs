using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShoppingApp
{
    public class ItemNameValidator
    {

        public static string Validate() {
            string itemName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(itemName))
            {
                AddItemByNameMessage.DisplayAddItemNameMessage();
                itemName = Console.ReadLine();
            }

            return itemName;
        }

    }
}
