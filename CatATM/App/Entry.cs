using CatATM.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatATM.App
{
    public class Entry
    {
        static void Main(string[] args)
        {
            AppScreen.Welcome();
            CatATM catAtm = new CatATM();

            catAtm.CheckUserAcctNumAndPin();


            Utilities.PressEnter();



        }
    }
}
