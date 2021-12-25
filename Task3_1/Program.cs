using System;
class Program
{
    static void Main(string[] args)
        {

        // до-диез первой октавы
        Key k1 = new Key(Note.C, Accidental.Sharp, Octave.First);
        Console.WriteLine(k1); // C# (First)

        // ре-бемоль первой октавы
        Key k2 = new Key(Note.D, Accidental.Flat, Octave.First);

        Console.WriteLine(k1.Equals(k2));     // True, это одна и та же клавиша
        Console.WriteLine(k2.CompareTo(k1));  // 0

        Key k3 = new Key(Note.D, Accidental.Flat, Octave.Second);
        Console.WriteLine(k3);

        Console.WriteLine(k2.Equals(k3));     // False
        Console.WriteLine(k2.CompareTo(k3));  // 12

        //Exception 
        //Key k4 = new Key(Note.D, Accidental.Flat, Octave.Sub_contra); 

    }
}

