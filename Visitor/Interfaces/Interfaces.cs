using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite_Iterator_Visitor.Iterator;
using Composite_Iterator_Visitor.Composite;
using Directory = Composite_Iterator_Visitor.Composite.Directory;
using File = Composite_Iterator_Visitor.Composite.File;

namespace Composite_Iterator_Visitor.Visitor.Interfaces
{
    public interface IVisitor
    {
        void Visit(Component component);    
    }
    public interface IFileSystem
    {
        void Accept(IVisitor visitor);
    }
}
