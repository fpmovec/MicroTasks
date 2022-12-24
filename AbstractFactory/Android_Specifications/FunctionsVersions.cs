using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric.Android_Specifications
{
    public class FunctionsVersion1_0 : IFunctionsVersion
    {
        public void FunctionsVersion()
        {
            Console.WriteLine("Android functions version 1.0");
        }
    }
    public class FunctionsVersion1_1 : IFunctionsVersion
    {
        public void FunctionsVersion()
        {
            Console.WriteLine("Android functions version 1.1");
        }
    }
    public class FunctionsVersion1_2 : IFunctionsVersion
    {
        public void FunctionsVersion()
        {
            Console.WriteLine("Android functions version 1.2");
        }
    }
}
