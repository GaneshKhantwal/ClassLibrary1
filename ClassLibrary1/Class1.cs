using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public void MethodA(Class2 cls2, int c)
        {
            //Class2 cls2 = new Class2();
            cls2.MethodB(this, 2);

        }
    }
}
