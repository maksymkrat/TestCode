using System;

namespace P_Composite_2
{
    public abstract class Component
    {
        protected string name;

        protected Component(string name)
        {
            this.name = name;
        }
        
        public virtual void Add(Component component){}

        public virtual void Remove(Component component)
        {
        }

        public virtual void Print()
        {
            Console.WriteLine(name);
        }
    }
}