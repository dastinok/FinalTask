using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк: ");
       
        int elements = int.Parse(Console.ReadLine());
        string[] Array = new string[elements]; 
        for (int i = 0; i < Array.Length; i++)
        {
            Console.Write("Введите строку №{0}:\r\n    ", i + 1);
            Array[i] = Console.ReadLine(); 
        }

        Console.WriteLine("Вы ввели следующие строки:");
        Console.Write("[");
    }
}