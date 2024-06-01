using System;
using System.Collections.Generic;

public class Set
{
    private HashSet<int> _elements = new HashSet<int>();

    public int Count { get { return _elements.Count; } }

    public bool IsEmpty { get { return _elements.Count == 0; } }

    public void AddElement(int element)
    {
        if (!_elements.Contains(element))
        {
            _elements.Add(element);
        }
    }

    public void RemoveElement(int element)
    {
        if (_elements.Contains(element))
        {
            _elements.Remove(element);
        }
    }

    public void Clear()
    {
        if (_elements.Count > 0)
        {
            _elements.Clear();
        }
    }

    public int[] GetAllElements()
    {
        int[] result = new int[_elements.Count];
        _elements.CopyTo(result);
        return result;
    }

    public bool ContainsElement(int element)
    {
        return _elements.Contains(element);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Set mySet = new Set();

        mySet.AddElement(1);
        mySet.AddElement(2);
        mySet.AddElement(3);
        mySet.AddElement(3);
        mySet.AddElement(4);

        Console.WriteLine($"Количество элементов: {mySet.Count}");
        Console.WriteLine($"Пустой ли набор: {mySet.IsEmpty}");

        mySet.RemoveElement(2);

        int[] allElements = mySet.GetAllElements();
        Console.WriteLine($"Все элементы: {string.Join(", ", allElements)}");

        Console.WriteLine($"Содержит 2: {mySet.ContainsElement(2)}");
        Console.WriteLine($"Содержит 3: {mySet.ContainsElement(3)}");

        mySet.Clear();

        Console.WriteLine($"Количество элементов: {mySet.Count}");
        Console.WriteLine($"Пустой ли набор: {mySet.IsEmpty}");
    }
}
