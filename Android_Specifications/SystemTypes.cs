using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric.Android_Specifications
{
    public class SystemVersion1_0 : IOperatingSystem
    {
        public void SystemType()
        {
            Console.WriteLine("Android system version 1.0");
        }
    }
    public class SystemVersion1_1 : IOperatingSystem
    {
        public void SystemType()
        {
            Console.WriteLine("Android system version 1.1");
        }
    }
    public class SystemVersion1_2 : IOperatingSystem
    {
        public void SystemType()
        {
            Console.WriteLine("Android system version 1.2");
        }
    }
}
