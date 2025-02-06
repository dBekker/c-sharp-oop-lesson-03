using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите ваше имя: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Ваше имя: {name}");

        Console.Write("Введите ваш возраст: ");
        int age;

        while(!int.TryParse(Console.ReadLine(), out age) ||  age < 0)
        {
            Console.WriteLine("Некорректный ввод. Введите число больше либо 0.");
            Console.Write("Введите ваш возраст: ");
        }

        Console.Write($"Ваш возраст: {age}");

        // Console.Write("Введите ваш пол (м/ж): ");
        // string gender = Console.ReadLine().Trim().ToLower();

        // if(gender == "м")
        // {

        // }
        // else
        // {

        // }
    }
} 