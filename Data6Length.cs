using System;

class Data6Length{
    public static void Main(string[] args)
    {
        int[] angka = new int[10];

        Console.WriteLine("Angka's Length: " + angka.Length);

        for (int i = 0; i < angka.Length; i++){
            angka[i] = i * i;
        }

        Console.Write("Menampilkan Isi Array Angka: ");
        for (int i = 0; i < angka.Length; i++)
        {
            Console.Write(angka[i] + " ");
        }
        Console.WriteLine();
    }
}