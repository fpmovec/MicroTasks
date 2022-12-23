using Composite_Iterator_Visitor.Visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Iterator_Visitor.Composite
{
    public abstract class Component
    {
        public string? Name { get; set; }
        public Component(string? name) => Name = name;
        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract List<Component> GetComponents();
        public abstract void PrintNodes();
    }

    public class Directory : Component, IFileSystem
    {
        List<Component> components = new();
        public Directory(string name) : base(name) { }

        public override void Add(Component component) 
            => components.Add(component);
        public override void Remove(Component component)
            => components.Remove(component);
        public override List<Component> GetComponents()
            => components;
        public void Accept(IVisitor visitor)
            => visitor.Visit(this);
        public override void PrintNodes()
        {
            Console.WriteLine("Node: " + Name);
            foreach (var component in components)
                component.PrintNodes();
        }
    }

    public class File : Component, IFileSystem
    {
        public File(string name) : base(name) { }
        public override void Add(Component component)
            => throw new InvalidOperationException();

        public override void Remove(Component component)
            =>throw new InvalidOperationException();

        public override List<Component> GetComponents()
           => throw new InvalidOperationException();
   
        public override void PrintNodes()
           => Console.WriteLine(Name);

        public void Accept(IVisitor visitor)
           => visitor.Visit(this);

    }
}
