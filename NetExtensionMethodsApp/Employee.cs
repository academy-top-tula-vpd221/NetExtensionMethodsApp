using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExtensionMethodsApp
{
    public partial class Employee
    {
        public string Name { set; get; }
        public int Age { set; get; }
        public Employee() { }
        partial void Print();

        void PrintFull() 
        {
            Print();
        }
    }
}
