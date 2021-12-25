using System;

public struct Key : IComparable<Key>
{
    private Octave _octave;
    private Note _note;
    private Accidental _accidental;
    public Key(Note note, Accidental accidental, Octave octave)
    {
        CheckEnumValue(note);
        CheckEnumValue(accidental);
        CheckEnumValue(octave);
        _octave = octave;
        _note = note;
        _accidental = accidental;
        int keyValue = GetKeyValue();
        const int minKeyValue = 10;
        const int maxKeyValue = 96;
        if (keyValue < minKeyValue || keyValue> maxKeyValue)
        {
            throw new ArgumentOutOfRangeException();
        }
    }

    private static void CheckEnumValue<T>(T value) where T: Enum
    {
        if (!Enum.IsDefined(typeof(T), value)) throw new ArgumentException(value.ToString());
    }

    private int GetKeyValue()
    {
        return (int)_octave + (int)_note + (int)_accidental;
    }
    public int CompareTo(Key k)
    {
        return GetKeyValue() - k.GetKeyValue();
    }
    public override bool Equals(object obj)
    {
        if(obj is Key k)
        {
            return GetKeyValue() == k.GetKeyValue();
        }
        return false;
    }

    public override int GetHashCode()
    {
        return GetKeyValue();
    }

    public override string ToString()
    {
        switch (_accidental)
        {
            case Accidental.Flat:
                return $"{_note} b {_octave}";
            case Accidental.Sharp:
                return $"{_note} # {_octave}";
            default:
                return $"{_note} {_octave}";
        }
    }
}

