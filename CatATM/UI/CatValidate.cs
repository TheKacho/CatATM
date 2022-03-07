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
                    Console.WriteLine("The cat hisses angrily at you! \nIts trying to say invalid input, try again!\n");
                }
            }
            return default;
        }
    }
}
