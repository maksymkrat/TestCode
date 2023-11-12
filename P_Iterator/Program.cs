

using System.Collections;

class Program
{
    public static void Main(string[] args)
    {
        ConcreteAggregate a = new ConcreteAggregate();
        a[0] = "Item A";
        a[1] = "Item B";
        a[2] = "Item C";
        a[3] = "Item D";
 
        // Create Iterator and provide aggregate
        Iterator i = a.CreateIterator();
        
        Console.WriteLine("Iterating over collection:");
        
        object item = i.First();
        while (item != null)
        {
            Console.WriteLine(item);
            item = i.Next();
        }

        // Wait for user
        Console.ReadKey();
    }
}

abstract class Iterator
{
    public abstract object First();
    public abstract object Next();
    public abstract bool IsDone();
    public abstract object CurrentItem();
}

class ConcreteIterator : Iterator
{

    private ConcreteAggregate _aggreate;
    private int _current = 0;

    public ConcreteIterator(ConcreteAggregate aggregate)
    {
        this._aggreate = aggregate;
    }
    public override object First()
    {
        return _aggreate[0];
    }

    public override object Next()
    {
        object ret = null;
        if (_current < _aggreate.Count - 1)
        {
            ret = _aggreate[++_current];
        }

        return ret;
    }

    public override bool IsDone()
    {
        return _current >= _aggreate.Count;
    }

    public override object CurrentItem()
    {
        return _aggreate[_current];
    }
}

abstract class Aggregate
{
    public abstract Iterator CreateIterator();
}

class ConcreteAggregate : Aggregate
{
    private ArrayList _items = new ArrayList();
    
    public override Iterator CreateIterator()
    {
        return new ConcreteIterator(this);
    }

    public int Count
    {
        get { return _items.Count; }
    }

    public object this[int index]
    {
        get { return _items[index]; }
        set{ _items.Insert(index, value);}
    }
}