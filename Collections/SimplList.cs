using System.Collections;

namespace Collections;

public class SimplList : IList
{
    private readonly object[] contents = new object[8];

    private int count;

    public SimplList()
    {
        count = 0;
    }

    public IEnumerator GetEnumerator()
    {
        for (int i = 0; i < Count; i++)
        {
            yield return contents[i];
        }
    }

    public void CopyTo(Array array, int index)
    {
        int j = index;
        for (int i = 0; i < Count; i++)
        {
            array.SetValue(contents[i],j);
            j++;

        }
    }

    public int Count
    {
        get { return count; }
    }
    public bool IsSynchronized
    {
        get { return false; }
    }
    public object SyncRoot
    {
        get { return null; }
    }
    public int Add(object? value)
    {
        if (count < contents.Length - 1)
        {
            contents[count] = value;
            count++;
            return (count - 1);
        }

        return -1;
    }

    public void Clear()
    {
        count = 0;
    }

    public bool Contains(object? value)
    {
        for (int i = 0; i < Count; i++)
        {
            if (contents[i] == value)
            {
                return true;
            }
        }

        return false;
    }

    public int IndexOf(object? value)
    {
        for (int i = 0; i < Count; i++)
            if (contents[i] == value)
                return i;
        return -1;
    }

    public void Insert(int index, object? value)
    {
        if ((count + 1 < contents.Length) && (index < Count) && (index >= 0))
        {
            count++;

            for (int i = Count-1; i >  index; i--)
            {
                contents[i] = contents[i - 1];
            }

            contents[index] = value;
        }
    }

    public void Remove(object? value)
    {
        RemoveAt(IndexOf(value));
    }

    public void RemoveAt(int index)
    {
        if ((index >= 0) && (index < Count))
        {
            for (int i = index; i < Count-1; i++)
            {
                contents[i] = contents[i + 1];
            }

            count--;
        }
    }

    public bool IsFixedSize
    {
        get { return true; }
    }
    public bool IsReadOnly
    {
        get { return false; }
    }

    public object? this[int index]
    {
        get { return contents[index];}
        set { contents[index] = value; }
    }
}