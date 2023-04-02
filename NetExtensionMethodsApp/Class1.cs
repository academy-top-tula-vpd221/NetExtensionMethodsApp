using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExtensionMethodsApp
{
    public partial class Employee
    {
        public string Phone { set; get; }

        partial void Print()
        {
            Console.WriteLine($"{Name} {Age}");
        }
    }
}
