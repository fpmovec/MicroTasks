using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{

    ////////////////////
    public interface IBuildNumber
    {
        void BuildNumber();
    }
    public interface IOperatingSystem
    {
        void SystemType();
    }
    public interface IFunctionsVersion
    {
        void FunctionsVersion();
    }
    /////////////////////
    
    public interface IMobile
    {
        IOperatingSystem CreateOS();
        IFunctionsVersion CreateFV();
        IBuildNumber CreateBN();
    }
}
