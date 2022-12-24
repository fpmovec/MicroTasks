using Composite_Iterator_Visitor.Composite;
using Composite_Iterator_Visitor.Visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Directory = Composite_Iterator_Visitor.Composite.Directory;
using File = Composite_Iterator_Visitor.Composite.File;

namespace Composite_Iterator_Visitor.Visitor.Classes
{
    public class DirectoryVisitor : IVisitor
    {
        public void Visit(Component dir)
        {
            Console.WriteLine("| I visited the \"" + dir.Name + "\" directory");
        }
    }
    public class FileVisitor : IVisitor
    {
        public void Visit(Component file)
        {
            Console.WriteLine("| I visited the \"" + file.Name + "\" file");
        }
    }
}
