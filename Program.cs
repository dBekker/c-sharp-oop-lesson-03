using System;

class Program
{
    static void Main()
    {
        // Создание объекта - Персона
        Person person = null;
        bool inCorrectGender = true;
        while(inCorrectGender)
        {
            Console.Write("Введите ваш пол (м/ж): ");
            string gender = Console.ReadLine().Trim().ToLower();
            switch(gender)
            {
                case "м":
                    person = new BoyPerson();
                    inCorrectGender = false;
                    break;
                case "ж":
                    person = new GirlPerson();
                    inCorrectGender = false;
                    break;
                default:
                    Console.WriteLine("Некорректный ввод, допустимые значения - (м/ж): ");
                    break;
            }
        }
        
        Console.Write("Введите ваше имя: ");
        
        // Установка имени
        person.setName(Console.ReadLine());
        
        Console.WriteLine($"Ваше имя: {person.getName(false)}");

        Console.Write("Введите ваш возраст: ");

        // Установка возраста
        while((int.TryParse(Console.ReadLine(), out person.Age) == false) ||  (person.Age < 0))
        {
            Console.WriteLine("Некорректный ввод. Введите число больше либо 0.");
            Console.Write("Введите ваш возраст: ");
        }

        Console.Write($"Ваш возраст: {person.Age}");

        // Установка любимой вещи
        person.askPreferense();

        // Вывод сводной информации
        Console.WriteLine(person.displayInfo());
        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
} 