using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric.Android_Specifications
{
    public class BuildNumber1_0 : IBuildNumber
    {
        public void BuildNumber()
        {
            Console.WriteLine("Android build version 1.0");
        }
    }
    public class BuildNumber1_1 : IBuildNumber
    {
        public void BuildNumber()
        {
            Console.WriteLine("Android build version 1.1");
        }
    }
    public class BuildNumber1_2 : IBuildNumber
    { 
        public void BuildNumber()
        {
            Console.WriteLine("Android build version 1.2");
        }
    }

}
