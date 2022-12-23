using Composite_Iterator_Visitor.Composite;
using Composite_Iterator_Visitor.Iterator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Directory = Composite_Iterator_Visitor.Composite.Directory;

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



                if (comp.GetType() == typeof(Directory))
                {
                    Console.WriteLine("Directory: " + comp.Name);
                    SeeFileSystem(new AllComponents(comp.GetComponents()));
                }
                else Console.WriteLine("      File: " + comp.Name);

            }
        }
    }
}
