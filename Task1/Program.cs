namespace Task1;

internal class Program
{
    static void Main(string[] args)
    {



    }
}


public interface INum
{
    int Num1 { get; set; }
    int Num2 { get; set; }
    int CalculateSum();
}

public class Sum : INum
{
    int INum.Num1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    int INum.Num2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public int CalculateSum()
    {
        return Num1 + Num2;
    }

    int INum.CalculateSum()
    {
        throw new NotImplementedException();
    }
}
