using System.Collections;

namespace Collections;

public class ElementCollection //: IEnumerable, IEnumerator
{
     readonly Element[] elements = new Element[4];


     public Element this[int index]
     {
          get { return elements[index]; }
          set { elements[index] = value; }
     }

      int position = -1;

      public ElementCollection GetEnumerator()
      {
         // return (IEnumerator)this;
         return this;
      }

      public bool MoveNext()
      {
          if (position < elements.Length - 1)
          {
              position++;
              return true;
          }
         // ((IEnumerator) this).Reset();
        // Reset();
          return false;
      }

     
      public object Current
      {
          get { return elements[position]; }
      }
}