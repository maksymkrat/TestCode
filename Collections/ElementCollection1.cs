using System.Collections;

namespace Collections;

public class ElementCollection1 : ICollection
{
    public object SyncRoot
    {
        get { return syncRoot; }
    }
    
    public int Count
    {
        get { return elements.Length; }
    }
    public bool IsSynchronized
    {
        get { return true; }
    }

    private readonly object syncRoot = new object();
    private readonly object[] elements =  {1, 2, 3, 4};

    public IEnumerator GetEnumerator()
    {
        return elements.GetEnumerator();
    }

    public void CopyTo(Array array, int index)
    {
        var arr = array as object[];
        if (arr == null)
            throw new ArgumentException("expectiong array to be object[]");

        for (int i = 0; i < array.Length; i++)
        {
            arr[index++] = elements[i];
        }
    }
    

    
}