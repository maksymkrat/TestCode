
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;


public class Program
{
    
    public static void Main(string[] args)
    {
        Foo foo = new Foo()
        {
            Stuff = 111,
            Whatever = "adfas"
        };

        var foo2 = foo.DeepCopy();
        foo2.Stuff = 222;
        var foo3 = foo.DeepCopyXml();
        foo3.Stuff = 333;
        
        Console.WriteLine(foo);
        Console.WriteLine(foo2);
        Console.WriteLine(foo3);

    }
}

//
// var john = new Person( new []{"John", "Smith"}, new Address("London Road", 123));
//
// var john1 = new Person(john);
// john1.Address.HouseNumber = 4444;
//
// Console.WriteLine(john);
// Console.WriteLine(john1);
//
// public class Person
// {
//     public string[] Names;
//     public Address Address;
//
//     public Person(string[] names, Address address)
//     {
//         Names = names;
//         Address = address;
//     }
//
//     public Person(Person other)
//     {
//         Names = new string[other.Names.Length];
//         Address = new Address(other.Address);
//         Array.Copy(other.Names, Names, other.Names.Length);
//     }
//
//     public override string ToString()
//     {
//         return $"{nameof(Names)}: {string.Join(' ', Names)}, {nameof(Address)}: {Address}";
//     }
// }
//
// public class Address
// {
//     public string StreetName;
//     public int HouseNumber;
//
//     public Address(string streetName, int houseNumber)
//     {
//         StreetName = streetName;
//         HouseNumber = houseNumber;
//     }
//
//     public Address(Address address)
//     {
//         StreetName = address.StreetName;
//         HouseNumber = address.HouseNumber;
//     }
//
//     public override string ToString()
//     {
//         return $"{nameof(StreetName)}: {StreetName}, {nameof(HouseNumber)}: {HouseNumber}";
//     }
// }


//---------------------------------



public class Foo
{
    public uint Stuff;
    public string Whatever;

    public override string ToString()
    {
        return $"{nameof(Stuff)}: {Stuff}, {nameof(Whatever)}: {Whatever}";
    }
}

public static class ExtensionMethods
{
    public static T DeepCopy<T>(this T self)
    {
        using (var  stream = new MemoryStream())
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream,self);
            stream.Seek(0, SeekOrigin.Begin);
            object copy = formatter.Deserialize(stream);
            return (T) copy;

        }
    }
    
    public static T DeepCopyXml<T>(this T self)
    {
        using (var  stream = new MemoryStream())
        { 
            XmlSerializer s = new XmlSerializer(typeof(T));
          s.Serialize(stream, self);
          stream.Position = 0;
          return (T) s.Deserialize(stream);
        }
    }
}

