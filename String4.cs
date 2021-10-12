using System;

public class String4 {
    public static void Main(string[] args)
    {
        string awal = "C# membuat string mudah.";

        //Substring
        string substr = awal.Substring(5,12);

        Console.WriteLine("String Awal: " + awal);
        Console.WriteLine("Substring: " + substr);
    }
}