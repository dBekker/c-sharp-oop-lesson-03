using System;

class Person 
{
    public string Name;
    public int Age;
    public string Gender;
    public string PrefferedThing;
}

class Program
{
    static void Main()
    {
        Person person = new Person();
        Console.Write("Введите ваше имя: ");
        person.Name = Console.ReadLine();
        Console.WriteLine($"Ваше имя: {person.Name}");

        Console.Write("Введите ваш возраст: ");

        while(!int.TryParse(Console.ReadLine(), out person.Age) ||  person.Age < 0)
        {
            Console.WriteLine("Некорректный ввод. Введите число больше либо 0.");
            Console.Write("Введите ваш возраст: ");
        }

        Console.Write($"Ваш возраст: {person.Age}");

        Console.Write("Введите ваш пол (м/ж): ");
        person.Gender = Console.ReadLine().Trim().ToLower();

        if(person.Gender == "м")
        {
            Console.Write("Введите вашу любимую марку машины: ");
            person.PrefferedThing = Console.ReadLine();
            Console.WriteLine($"Приятно познакомиться, {person.Name}. Ваш возраст {person.Age}. Ваша любимая машина {person.PrefferedThing}");
        }
        else
        {
            Console.Write("Введите ваши любимые цветы: ");
            person.PrefferedThing = Console.ReadLine();
            Console.WriteLine($"Приятно познакомиться, {person.Name}. Ваш возраст {person.Age}. Ваши любимые цветы {person.PrefferedThing}");
        }

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
} 