using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShoppingApp
{
    public class ItemModel
    {
        public string ItemName { get; set; }
        public double ItemPrice { get ; set; }
        public int ItemQuantity { get; set; }
        public string ItemDescription { get; set; }

 
    }

}
