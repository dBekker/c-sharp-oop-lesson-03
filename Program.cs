using System;

// Интерфейсы для разделения ответственности (ISP)
public interface INameable
{
    string Name { get; set; }
}

public interface IAgeable
{
    int Age { get; set; }
}

public interface IPreference
{
    string Preference { get; set; }
    void AskPreference();
}

// Абстрактный класс Person (OCP, LSP)
public abstract class Person : INameable, IAgeable, IPreference
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Preference { get; set; }
    public abstract void AskPreference();
}

// Конкретные реализации (OCP, LSP)
public class BoyPerson : Person
{
    public override void AskPreference()
    {
        Console.Write("Введите ваше любимое занятие: ");
        Preference = Console.ReadLine();
    }
}

public class GirlPerson : Person
{
    public override void AskPreference()
    {
        Console.Write("Введите ваше любимое занятие: ");
        Preference = Console.ReadLine();
    }
}

public class NonBinaryPerson : Person
{
    public override void AskPreference()
    {
        Console.Write("Введите ваше любимое занятие: ");
        Preference = Console.ReadLine();
    }
}

// Фабрика для создания объектов (DIP)
public interface IPersonFactory
{
    Person CreatePerson(string gender);
}

public class PersonFactory : IPersonFactory
{
    public Person CreatePerson(string gender)
    {
        return gender.ToLower() switch
        {
            "м" => new BoyPerson(),
            "ж" => new GirlPerson(),
            _ => null
        };
    }
}

// Классы для обработки ввода/вывода (SRP)
public class PersonInputHandler
{
    public Person GetPersonDetails(IPersonFactory factory)
    {
        Person person = null;
        while (person == null)
        {
            Console.Write("Введите ваш пол (м/ж): ");
            string gender = Console.ReadLine().Trim().ToLower();
            person = factory.CreatePerson(gender);
            if (person == null)
            {
                Console.WriteLine("Некорректный ввод. Введите 'м' или 'ж'.");
            }
        }
        
        Console.Write("Введите ваше имя: ");
        person.Name = Console.ReadLine();
        
        int age;
        Console.Write("Введите ваш возраст: ");
        while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
        {
            Console.WriteLine("Некорректный ввод. Введите положительное число.");
        }
        person.Age = age;
        
        person.AskPreference();
        
        return person;
    }
}

public class PersonOutputHandler
{
    public void DisplayPersonInfo(Person person)
    {
        Console.WriteLine($"Приятно познакомиться!");
        Console.WriteLine($"Имя: {person.Name}");
        Console.WriteLine($"Возраст: {person.Age}");
        Console.WriteLine($"Любимое занятие: {person.Preference}");
    }
}

// Основная программа
class Program
{
    static void Main()
    {
        IPersonFactory personFactory = new PersonFactory();
        PersonInputHandler inputHandler = new PersonInputHandler();
        PersonOutputHandler outputHandler = new PersonOutputHandler();

        Person person = inputHandler.GetPersonDetails(personFactory);
        outputHandler.DisplayPersonInfo(person);

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
