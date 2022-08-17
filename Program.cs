using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface_with_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartPhone sony = new SmartPhone();
            sony.call();
            sony.Message();
            sony.Branding();
            sony.camera();
            sony.Video();
            Console.WriteLine("\n*****************");

            SmartPhoneWithBaseBraning nokia = new SmartPhoneWithBaseBraning();
            nokia.call();
            nokia.Message();
            nokia.Branding();
            nokia.camera();
            nokia.Video();

            Console.ReadLine();
        }
    }
}
