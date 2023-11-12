// See https://aka.ms/new-console-template for more information

using System.Collections;
using Collections;

class Program
{
    public static void Main(string[] args)
    {
        // ElementCollection collection = new ElementCollection();
        // collection[0] = new Element(2, 2);
        // collection[1] = new Element(3, 3);
        // collection[2] = new Element(4, 4);
        // collection[3] = new Element(5, 5);
        //
        // foreach (Element v in collection)
        // {
        //     Console.WriteLine("{0}, {1}",v.ElementA, v.ElementB);
        // }
        
        //------------

        // ElementCollection1 collection1 = new ElementCollection1();
        //
        // foreach (var VARIABLE in collection1)
        // {
        //     Console.WriteLine(VARIABLE);
        // }
        
        //--------------

        ArrayList list = new ArrayList();

        var s = "hey";
        list.Add(s);
        list.Add("ff");
        list.Add(10);
        list.Add(new object());
    }
}