using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Stack<T> : IEnumerable<T>
{
    private IList<T> custom_Stack;

    public Stack()
    {
        this.custom_Stack = new List<T>();
    }

    public void Push(T item)
    {
        this.custom_Stack.Insert(0, item);
    }

    public T Pop()
    {
        if (!this.custom_Stack.Any())
        {
            throw new ArgumentException("No elements");
        }

        var popedItem = custom_Stack.First();
        custom_Stack.RemoveAt(0);
        return popedItem;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return this.custom_Stack.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
