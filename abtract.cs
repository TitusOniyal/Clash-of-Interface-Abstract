using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface_with_Abstract
{
    abstract class branding
    {
        public virtual void  Branding() {
            Console.WriteLine("Bell Branding");     //if this method defined, can be override in child
        }
        //public void Ring() {                        //if this method defined, cannot be override
        //    Console.WriteLine("Rocky");
        //}
        /*public abstract void MesRing(); */            //if this method defined, should be defined in child 
    }

}
