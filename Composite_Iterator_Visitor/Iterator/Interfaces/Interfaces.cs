using Composite_Iterator_Visitor.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Iterator_Visitor.Iterator.Interfaces
{
    public interface IComponentIterator
    {
        bool HasNext();
        Component NextComponent();
    }

    public interface IComponentNumerable
    {
        IComponentIterator CreateNumerator();
        int Count { get; }
        Component this[int index] { get; }
    }
}
