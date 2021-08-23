using System;
using System.Collections.Generic;
namespace NewShoppingApp
{
    public class MenuInputCapture
    {
        public static void Capture()
        {
            List<ItemModel> itemList = ShoppingCartDataCapture.Capture();
            bool menuReset;
            do
            { 
                MenuMessage.DisplayMenuMessage();
                switch (MenuInputValidator.Validate())
                {
                    case "a":
                        itemList.Add(ItemDataCapture.Capture());
                        menuReset = true; 
                        break;
                    case "r":
                        itemList = RemoveItemFromShoppingCart.RemoveItem(itemList);
                        menuReset = true;
                        break;
                    case "c":
                        ChangeItemQuantity.ChangeQuantity(itemList);
                        menuReset = true;
                        break;
                    case "i":
                        DisplayShoppingCart.DisplayItemDescription(itemList);
                        menuReset = true;
                        break;
                    case "o":
                        DisplayShoppingCart.Display(itemList);
                        menuReset = true;
                        break;
                    case "q":
                        menuReset = false;
                        break;
                    case "reset":
                        menuReset = true;
                        break;
                    default:
                        EnterValidMenuSelectionMessage.DisplayMessage();
                        menuReset = true;
                        break;
                }
            } while (menuReset == true);

        }
    }
}




