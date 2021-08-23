using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShoppingApp
{
    public class ShoppingCartDataCapture
    {
        public static List<ItemModel> Capture()
        {
            ShoppingCartModel shoppingCart = new ShoppingCartModel();
            shoppingCart.Items = new List<ItemModel>();
            List<ItemModel> itemList = shoppingCart.Items;

            return itemList;
        }

        
    }
}
