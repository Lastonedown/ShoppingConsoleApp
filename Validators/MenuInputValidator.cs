using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShoppingApp
{
    public class MenuInputValidator
    {


        public static string Validate()
        {
            string userInput = Console.ReadLine();
            if (string.IsNullOrEmpty(userInput) || string.IsNullOrWhiteSpace(userInput))
            {
                EnterValidMenuSelectionMessage.DisplayMessage();
                return "reset";
            }
            else
            {
                return userInput;
            }
            
        }
    }
}
    
