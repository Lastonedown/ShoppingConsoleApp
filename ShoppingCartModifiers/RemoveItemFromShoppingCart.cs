using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShoppingApp
{
    public class RemoveItemFromShoppingCart
    {

        public static List<ItemModel> RemoveItem(List<ItemModel> itemList)
        {
            string itemToRemove;
            
            ItemToRemoveMessage.DisplayItemToRemoveMessage();
            itemToRemove = Console.ReadLine();
            

            if (ShoppingCartValidator.ValidateListSize(itemList) == true)
            {
              
                for ( int i = 0; i < itemList.Count; i++)
                {
                    if (itemList[i].ItemName == itemToRemove)
                    {
                        itemList.RemoveAt(i);
                        ItemRemovedMessage.DisplayItemRemovedMessage();
                    }
                    else
                    {
                        ItemNotFoundMessage.DisplayItemNotFoundMessage();
                    }
                }
                
            } 
            return itemList;
        }
    }
}
