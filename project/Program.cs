// Дан файл(nums.txt), содержащий целые числа, через пробел.
// Удалите из него все четные числа;

using System;
using System.IO;

class work_3_2
{
    static void Main()
    {
        string filePath = "nums.txt";
        string numbers = "11 12 13 14 15 16 17 18 19 20";
        File.WriteAllText(filePath, numbers);
        Console.WriteLine("Файл " + filePath + " был создан и заполнен целыми числами.");
        string data = File.ReadAllText(filePath);
        string[] numbersStr = data.Split(' ');
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (string number in numbersStr)
            {
                int num = int.Parse(number);
                if (num % 2 != 0)
                {
                    writer.Write($"{num} ");
                }
            }
        }
        Console.WriteLine("Четные числа были удалены из файла.");
    }
}


