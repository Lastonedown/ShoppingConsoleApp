using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NewShoppingApp {
    public class DisplayShoppingCart
    {
        private double shoppingCartTotal { get; set; }
        public static void Display(List<ItemModel> itemList)
        {
            if (ShoppingCartValidator.ValidateListSize(itemList) == true)
            {
                List<double> itemPriceTotals = new();
                double itemPriceTotal;
                double shoppingCartTotal;
                foreach (var item in itemList)
                {
                    itemPriceTotal = item.ItemPrice * item.ItemQuantity;
                    Console.WriteLine($"Item Name: {item.ItemName} | Item Price: ${item.ItemPrice} | Item Quantity: {item.ItemQuantity} | Item Description: {item.ItemDescription} | Item Total ${itemPriceTotal}");
                    itemPriceTotals.Add(itemPriceTotal);
                } 
                shoppingCartTotal = itemPriceTotals.Sum(); 
                Console.WriteLine($"Shopping Cart Total ${shoppingCartTotal}");
            } 
        }
        public static void DisplayItemDescription(List<ItemModel> itemList)
        {
            if (ShoppingCartValidator.ValidateListSize(itemList) == true)
            {
                foreach (var item in itemList)
                {

                    Console.WriteLine($"Item Name: {item.ItemName} | Item Description: {item.ItemDescription}");
                }
            }
        }
    }
}
