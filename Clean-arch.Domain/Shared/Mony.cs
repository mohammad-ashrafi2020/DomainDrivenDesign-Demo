using Microsoft.VisualBasic.CompilerServices;

namespace Clean_arch.Domain.Shared;

public class Mony : BaseValueObject
{
    public int RialValue { get; }

    public Mony(int rialValue)
    {
        if (rialValue < 0)
            throw new InvalidDataException();

        RialValue = rialValue;
    }

    public static Mony FromRial(int value)
    {
        return new Mony(value);
    }
    public static Mony FromTooman(int value)
    {
        return new Mony(value * 10);
    }

    public static Mony operator +(Mony firstMony, Mony mony2)
    {
        return new Mony(firstMony.RialValue + mony2.RialValue);
    }

    public override string ToString()
    {
        return RialValue.ToString("#,0");
    }

    public static Mony operator -(Mony firstMony, Mony mony2)
    {
        return new Mony(firstMony.RialValue - mony2.RialValue);
    }
}