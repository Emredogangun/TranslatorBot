using ozdilekteyim.Context;
using ozdilekteyim.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ozdilekteyim
{
    class Program
    {
        static void Main(string[] args)
        {
            

            DriverChrome driverChrome = new DriverChrome();
            driverChrome.translateUrl("https://translate.google.com/?sl=tr&tl=ru&op=translate");

        }

    }
}
