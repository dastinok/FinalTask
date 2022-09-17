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

         for (int i = 0; i < Array.Length; i++)
        {
            Console.Write(Array[i] + "  ");
        }
         Console.WriteLine("]");

        Console.WriteLine("");
        Console.WriteLine("Длина строки равно или меньше 3-х символов: ");

        Console.Write("[");
        var newArray = Array.Where(x => x.Length <= 3).ToArray();
        for (int i = 0; i < newArray.Length; i++)
        {
            Console.Write(newArray[i] + "  ");
        }
        Console.WriteLine("]");
        Console.Write("Нажмите [Enter] для выхода...");
        Console.ReadLine();
    }
}
    
