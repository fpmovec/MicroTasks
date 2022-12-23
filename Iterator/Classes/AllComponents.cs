using Composite_Iterator_Visitor.Composite;
using Composite_Iterator_Visitor.Iterator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Iterator_Visitor.Iterator.Classes
{
    public class AllComponents : IComponentNumerable
    {
        public List<Component> components;
        public AllComponents(List<Component> comp) => components = comp;

        public int Count
        {
            get { return components.Count; }
        }

        public Component this[int inidex]
        { 
            get { return components[inidex]; }
        }

        public IComponentIterator CreateNumerator()
        {
            return new ComponentNumerator(this);
        }
    }

    public class ComponentNumerator : IComponentIterator
    {
        IComponentNumerable aggregate;
        int index = 0;
        public ComponentNumerator(IComponentNumerable a) =>  aggregate = a;
        
        public bool HasNext() =>  index < aggregate.Count;
        public Component NextComponent() => aggregate[index++];
    }
}
