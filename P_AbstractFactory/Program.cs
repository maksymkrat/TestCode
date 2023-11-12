
using System;

namespace P_AbstractFactory
{
     class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run();

            AbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run();
            

        }
    }

     abstract class AbstractFactory
     {
         public abstract AbstractProductA createProductsA();
         public abstract AbstractProductB createProductsB();

     }

     class ConcreteFactory1 : AbstractFactory
     {
         public override AbstractProductA createProductsA()
         {
             return new ProductA1();
         }

         public override AbstractProductB createProductsB()
         {
             return new ProductB1();
         }
     }
     
     class ConcreteFactory2 : AbstractFactory
     {
         public override AbstractProductA createProductsA()
         {
             return new ProductA2();
         }

         public override AbstractProductB createProductsB()
         {
             return new ProductB2();
         }
     }

     abstract class AbstractProductA
     {
         
     }
     abstract class AbstractProductB
     {
         public abstract void Interact(AbstractProductA a);
     }

     class  ProductA1 : AbstractProductA
     {
         
     }

     class ProductB1 : AbstractProductB
     {
         public override void Interact(AbstractProductA a)
         {
             Console.WriteLine(this.GetType().Name + 
                               " interact with " + a.GetType().Name);
         }
     }

     class ProductA2 : AbstractProductA
     {
         
     }

     class ProductB2 : AbstractProductB
     {
         public override void Interact(AbstractProductA a)
         {
             Console.WriteLine(this.GetType().Name +
                               " interacts with " + a.GetType().Name);
         }
     }

     class  Client
     {
         private AbstractProductA _abstractProductA;
         private AbstractProductB _abstractProductB;

         public Client(AbstractFactory factory)
         {
             _abstractProductA = factory.createProductsA();
             _abstractProductB = factory.createProductsB();
         }

         public void Run()
         {
             _abstractProductB.Interact(_abstractProductA);
         }
     }
}
