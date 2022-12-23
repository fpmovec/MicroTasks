using Composite_Iterator_Visitor.Composite;
using Composite_Iterator_Visitor.Iterator.Interfaces;
using Composite_Iterator_Visitor.Visitor.Classes;
using Composite_Iterator_Visitor.Visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Directory = Composite_Iterator_Visitor.Composite.Directory;
using File = Composite_Iterator_Visitor.Composite.File;

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
                    Console.Write("Directory: " + comp.Name + " ");
                    ((Directory)comp).Accept(new DirectoryVisitor());
                    SeeFileSystem(new AllComponents(comp.GetComponents()));
                }
                else
                {
                    Console.Write("      File: " + comp.Name + " ");
                    ((File)comp).Accept(new FileVisitor());
                }
            }
        }
    }
}
