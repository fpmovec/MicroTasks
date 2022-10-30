

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Example 1
            Mobile mobile = new Mobile("IOS", 1.0);

            Console.WriteLine();

            //Example 2
            Mobile mobile1 = new Mobile("Android", 1.2);
        }
    }

    public class MobileFactory
    {
        public IMobile createMobile(string platform, double version)
        {
            if (platform.Equals("IOS"))
            {
                return new IOSPlatform(version);
            }
            else if (platform.Equals("Android"))
            {
                return new AndroidPlatform(version);
            }

            throw new FormatException(platform);
        }
    }


    class IOSPlatform : IMobile
    {
        private double _functionsVersion;
        public IOSPlatform(double functionsVersion)
        {
            _functionsVersion = functionsVersion;
        }
        public IOperatingSystem CreateOS()
        {
            switch (_functionsVersion)
            {
                case 1.0: return new IOS_Specifications.SystemVersion1_0();
                case 1.1: return new IOS_Specifications.SystemVersion1_1();
                case 1.2: return new IOS_Specifications.SystemVersion1_2();
               
            }
            throw new ArgumentException("This version don't exist!");
        }
        public IFunctionsVersion CreateFV()
        {
            switch (_functionsVersion)
            {
                case 1.0: return new IOS_Specifications.FunctionsVersion1_0();
                case 1.2: return new IOS_Specifications.FunctionsVersion1_1();
                case 1.3: return new IOS_Specifications.FunctionsVersion1_2();
                
            }
            throw new ArgumentException("This version don't exist!");
        }
        public IBuildNumber CreateBN()
        {
           switch (_functionsVersion)
           {
                case 1.0: return new IOS_Specifications.BuildNumber1_0();
                case 1.1: return new IOS_Specifications.BuildNumber1_1();
                case 1.2: return new IOS_Specifications.BuildNumber1_2();
           }
            throw new ArgumentException("This version don't exist!");
        }
    }

    class AndroidPlatform : IMobile
    {
        private double _functionsVersion;
        public AndroidPlatform(double functionsVersion)
        {
            _functionsVersion = functionsVersion;
        }
        public IOperatingSystem CreateOS()
        {
                switch (_functionsVersion)
                {
                    case 1.0: return new Android_Specifications.SystemVersion1_0();
                    case 1.1: return new Android_Specifications.SystemVersion1_1();
                    case 1.2: return new Android_Specifications.SystemVersion1_2();
                }
            throw new ArgumentException("This version don't exist!");
        }
        public IFunctionsVersion CreateFV()
        {
            switch (_functionsVersion)
            {
                case 1.0: return new Android_Specifications.FunctionsVersion1_0();
                case 1.1: return new Android_Specifications.FunctionsVersion1_1();
                case 1.2: return new Android_Specifications.FunctionsVersion1_2();
            }
            throw new ArgumentException("This version don't exist!");
        }
        public IBuildNumber CreateBN()
        {
            switch (_functionsVersion)
            {
                case 1.0: return new Android_Specifications.BuildNumber1_0();
                case 1.1: return new Android_Specifications.BuildNumber1_1();
                case 1.2: return new Android_Specifications.BuildNumber1_2();
            }
            throw new ArgumentException("This version don't exist!");
        }
    }

    class Mobile
    {
        private IOperatingSystem _os;
        private IFunctionsVersion _version;
        private IBuildNumber _build;
        public Mobile(string platform, double version)
        {
            MobileFactory factory = new MobileFactory();
            IMobile mobile = factory.createMobile(platform, version);
            _os = mobile.CreateOS();
            _version = mobile.CreateFV();
            _build = mobile.CreateBN();

            _os.SystemType();
            _version.FunctionsVersion();
            _build.BuildNumber();

        }
    }
}
