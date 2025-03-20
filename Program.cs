using System;

public class PemrosesData
{
    public dynamic DapatkanNilaiTerbesar<T>(T x1 , T  x2 , T x3)
    {
        dynamic bilangan1 = x1;
        dynamic bilangan2 = x2;
        dynamic bilangan3 = x3;

        if (bilangan1 > bilangan2 && bilangan1 > bilangan3)
        {
            return bilangan1;
        }
        else if (bilangan2 > bilangan1 && bilangan2 > bilangan3)
        {
            return bilangan2;
        }
        else
        {
            return bilangan3;
        }
    }
}

public class Program
{
    public static void Main()
    {
        PemrosesData pemrosesData = new PemrosesData();
        Console.WriteLine("Nilai Terbesar : " + pemrosesData.DapatkanNilaiTerbesar<int>(10 , 30 , 22));

    }
}