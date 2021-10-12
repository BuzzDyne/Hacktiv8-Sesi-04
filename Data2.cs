using System;

public class Data2 {
    public static void Main(string[] args)
    {
        string[] contoh = new string[4]
        {
            "Mobo", "Processor", "PSU", "VGA"
        };

        System.Console.WriteLine("Semua data pada array:\n");

        foreach (string x in contoh)
        {
            System.Console.WriteLine(x);
        }

        System.Console.Write("\nFinished!");
    }
}