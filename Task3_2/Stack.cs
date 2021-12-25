using System;

public class Stack<T> : IStack<T>
{
    private const int StackSize = 777;
    private readonly T[] _elements = new T[StackSize];
    private int _index = -1;
    public bool IsEmpty() => _index == -1;

    public T Pop()
    {
        if (IsEmpty()) throw new InvalidOperationException();
        return _elements[_index--];
    }

    public void Push(T item)
    {
        if (_index == StackSize-1) throw new StackOverflowException();
        _elements[++_index] = item;
    }

    public override string ToString()
    {
        string output = "Stack elements: \n";
        for (int i = _index; i >= 0; i--) 
        { 
            output += $"{_elements[i]}\n";
        }
        return output;
    }
}

