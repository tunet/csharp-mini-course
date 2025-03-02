using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Exceptions;

namespace TestApp;

public class CustomList<T>
{
    public int Count { get; private set; }

    private T[] _items = new T[3];

    public T[] GetItems()
    {
        var arr = new T[Count];
        Array.Copy(_items, arr, Count);

        return arr;
    }

    public void Add(T item)
    {
        if (Count >= 3)
        {
            throw new FullListException();
        }

        _items[Count] = item;
        Count++;
    }
}

