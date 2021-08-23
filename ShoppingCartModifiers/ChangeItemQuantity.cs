using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShoppingApp
{
   public class ChangeItemQuantity
    {
        public static List<ItemModel> ChangeQuantity(List<ItemModel> itemList)
        {
            
    
            if (ShoppingCartValidator.ValidateListSize(itemList) == true)
            {  
                EnterItemToModifyMessage.Display();
                string itemName = ItemNameValidator.Validate(); 
                for (int i = 0; i < itemList.Count; i++)
                {
                    if (itemList[i].ItemName == itemName)
                    {
                        ItemQuantityMessage.DisplayEnterItemQtyMessage();
                        int newItemQuantity = ItemQuantityValidator.Validate();
                        itemList[i].ItemQuantity = newItemQuantity;
                        ItemQuantityMessage.DisplayQuantityUpdated();
                    }

                }
                
            }return itemList;
               
        }

    }
}
