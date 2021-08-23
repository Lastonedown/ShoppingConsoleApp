using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShoppingApp
{
    public class ShoppingCartValidator
    {
        public static bool ValidateListSize(List<ItemModel> itemList)
        {
            if (itemList.Count == 0)
            {
                ShoppingCartEmptyMessage.DisplayShoppingCartEmptyMessage();
                return false;
            }
            if (itemList.Count > 0)
            {
                return true;
            }

            return true;

        }
    }
}
