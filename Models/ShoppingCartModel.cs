using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShoppingApp
{
    public class ShoppingCartModel
    {
        public string ShoppingCartName { get; set; }

        private List<ItemModel> items;

        public List<ItemModel> Items
        {
            set { items = value; }
            get { return items; }
        }
    }
}
