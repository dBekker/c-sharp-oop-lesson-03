class Program
{
    static void Main()
    {
        Console.Write("Введите ваше имя: ");
        string name = Console.ReadLine();

        Console.Write("Введите ваш возраст: ");
        int age;
        while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
        {
            Console.WriteLine("Некорректный ввод. Введите число больше либо 0.");
        }

        Console.Write("Введите ваш пол (м/ж): ");
        string gender;
        while (true)
        {
            gender = Console.ReadLine().Trim().ToLower();
            if (gender == "м" || gender == "ж")
                break;
            Console.WriteLine("Некорректный ввод. Введите 'м' или 'ж': ");
        }

        Person person = gender == "м"
            ? new MalePerson(name, age, "")
            : new FemalePerson(name, age, "");

        person.AskPreference();
        person.DisplayInfo();

        Console.Write("У вас есть ребёнок? (да/нет): ");
        string hasChild;
        while (true)
        {
            hasChild = Console.ReadLine().Trim().ToLower();
            if (hasChild == "да" || hasChild == "нет")
                break;
            Console.WriteLine("Некорректный ввод. Введите 'да' или 'нет': ");
        }

        if (hasChild == "да")
        {
            Console.Write("Введите имя ребёнка: ");
            string childName = Console.ReadLine();

            Console.Write("Введите возраст ребёнка: ");
            int childAge;
            while (!int.TryParse(Console.ReadLine(), out childAge) || childAge < 0)
            {
                Console.WriteLine("Некорректный ввод. Введите число больше либо равное 0.");
            }

            ChildPerson child = new ChildPerson(childName, childAge, "");
            child.AskPreference();
            Console.WriteLine("\nИнформация о ребёнке:");
            child.DisplayInfo();
            Console.WriteLine();
        }

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}