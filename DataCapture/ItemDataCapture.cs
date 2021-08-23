using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShoppingApp
{
    public class ItemDataCapture
    {
      public static ItemModel Capture()
        {
            ItemModel output = new ItemModel();

            AddItemByNameMessage.DisplayAddItemNameMessage();
            output.ItemName = ItemNameValidator.Validate();

            ItemQuantityMessage.DisplayEnterItemQtyMessage();
            output.ItemQuantity = ItemQuantityValidator.Validate();
        
            EnterItemPriceMessage.DisplayEnterItemPriceMessage();
            output.ItemPrice = ItemPriceValidator.Validate();
          
            EnterItemDescriptionMessage.DisplayEnterItemDescriptionMessage();
            output.ItemDescription = ItemDescriptionValidator.Validate();

            return output;
        }
    }
}
