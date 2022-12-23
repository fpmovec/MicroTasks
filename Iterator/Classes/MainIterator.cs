using Composite_Iterator_Visitor.Composite;
using Composite_Iterator_Visitor.Iterator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Iterator_Visitor.Iterator.Classes
{
    public class MainIterator
    {
        public void SeeFileSystem(AllComponents all)
        {
            IComponentIterator iterator = all.CreateNumerator();
            while (iterator.HasNext())
            {
                Component comp = iterator.NextComponent();
                comp.PrintNodes();
            }
        }
    }
}
