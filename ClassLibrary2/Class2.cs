using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Class2
    {
        public void MethodB(Class1 cls1, int b)
        {
            cls1.MethodA(this,5);
         
        }
    }
}
