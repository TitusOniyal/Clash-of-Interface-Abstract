using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface_with_Abstract
{
    class SmartPhone: branding, ISmart
    {
        public void call()
        {
            Console.WriteLine("Call conected");
        }
        public void Message()
        {
            Console.WriteLine("Message sent");
        }
        public void Video() {
            Console.WriteLine("Playing video");
        }
        public void camera()
        {
            Console.WriteLine("Capturing images");
        }
        public override void Branding()
        {
            Console.WriteLine("Virgin Branding");
        }
    }
    class SmartPhoneWithBaseBraning : branding,ISmart
    {
        public void call()
        {
            Console.WriteLine("Call conected");

        }
        public void Message()
        {
            Console.WriteLine("Message sent");
        }
        public void Video()
        {
            Console.WriteLine("Playing video");
        }
        public void camera()
        {
            Console.WriteLine("Capturing images");
        }
    }
}
