using System;
using System.Globalization;

class String2 {
    public static void Main(string[] args)
    {
        string str1 = "Untuk pemrograman .NET, C# adalah #1.";
        string str2 = "Untuk pemrograman .NET, C# adalah #1.";
        string str3 = "String C# sangat tangguh";
        string strAtas, strBawah;
        int hasil, idx;

        Console.WriteLine("str1: " + str1);
        Console.WriteLine("Panjang str1: " + str1.Length);

        //lowerCase
        strBawah = str1.ToLower(CultureInfo.CurrentCulture);
        strAtas  = str1.ToUpper(CultureInfo.CurrentCulture);

        Console.WriteLine("str1 Lower Case: " + strBawah);
        Console.WriteLine("str1 Upper Case: " + strAtas + "\n");

        //str1 per char
        Console.WriteLine("Str1, char demi char:");
        for (int i = 0; i < str1.Length; i++){
            Console.Write(str1[i]);
        }
        System.Console.WriteLine();

        if (str1 == str2)
            System.Console.WriteLine("str1 == str2");
        else
            System.Console.WriteLine("str1 != str2");

        if (str1 == str3)
            System.Console.WriteLine("str1 == str3");
        else
            System.Console.WriteLine("str1 != str3");

        // Culture-sensitive Comparison
        hasil = string.Compare(str1, str3, StringComparison.CurrentCulture);
        if (hasil == 0)
            Console.WriteLine("str1 dan str3 sama\n");
        else if (hasil < 0)
            Console.WriteLine("str1 kurang dari str3\n");
        else
            Console.WriteLine("str1 lebih besar dari str3\n");

        // Assign string baru ke str2
        str2 = "Satu Dua Tiga Satu";

        // String search
        idx = str2.IndexOf("Satu", StringComparison.Ordinal);
        Console.WriteLine("Index kemunculan pertama dari 'Satu': " + idx);
    
        idx = str2.LastIndexOf("Satu", StringComparison.Ordinal);
        Console.WriteLine("Index kemunculan terakhir dari 'Satu': " + idx);
    }
}