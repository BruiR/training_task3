using System;

class Program
{
    static void Main(string[] args)
    {
        IStack<int> st1 = new Stack<int>();
        st1.Push(10);
        st1.Push(20);
        st1.Push(30);
        Console.WriteLine($"st1 => \n{st1}");
        Console.WriteLine(st1.IsEmpty());
        Console.WriteLine(st1.Pop());
        Console.WriteLine(st1.Pop());
        Console.WriteLine(st1.Pop());

        // Exception при попытке извлечь из пустого стека
        //Console.WriteLine(st1.Pop());

        Console.WriteLine($"st1 => \n{st1}");
        Console.WriteLine(st1.IsEmpty());

        st1.Push(40);
        st1.Push(50);
        st1.Push(60);
        Console.WriteLine(st1.IsEmpty());
        var st2 = st1.Reverse();
        Console.WriteLine($"st1 after reverse  => \n{st1}");
        Console.WriteLine($"st2 (=st1.Reverse();) => \n{st2}");


    }
}

