using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatATM.UI
{
    public static class CatValidate
    {

        //takes the user's input and converts the string to see if it is valid or not
        // if there are any non-integer values or letters in the string, it will prompt an error message
        public static T Convert<T>(string prompt)
        {
            bool valid = false;
            string userInput;

            while (!valid)
            {
                userInput = Utilities.UserInput(prompt);

                try
                {
                    var convert = TypeDescriptor.GetConverter(typeof(T));
                    if(convert != null)
                    {
                        return (T)convert.ConvertFromString(userInput);
                    }
                    else
                    {
                        return default;
                    }
                }
                catch
                {
                    Console.WriteLine("\nThe cat hisses angrily at you!\n \nIts trying to say invalid input, try again!\n");
                }
            }
            return default;
        }
    }
}
