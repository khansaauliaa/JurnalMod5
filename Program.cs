


using System;
using System.ComponentModel.DataAnnotations;


public class PemrosesData
{
    public dynamic DapatkanNilaiTerbesar<T>(T x1, T x2, T x3)
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
        Console.WriteLine("Nilai Terbesar : " + pemrosesData.DapatkanNilaiTerbesar<int>(10, 30, 22));

    }
}


public class SimpleDataBase<T>
{
    private List<T> data = StoredDataBase;
    private List<DataTime> inputDates;

    public static List<T> StoredDataBase { get; private set; }

    public void addNewData(T data)
    {
        StoredDataBase.Add(data);
        inputDates.Add(DateTime.Now);

    }

    public void PrintAllData()
    {
        for (int i = 0; i < StoredDataBase.count; i++) { 
         Console.WriteLine(StoredDataBase[i].ToString() + " " + inputDates[i].ToString());
        }
    }
}
