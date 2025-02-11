abstract class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string PreferredThing { get; set; }

    public Person(string name, int age, string preferredThing)
    {
        Name = name;
        Age = age;
        PreferredThing = preferredThing;
    }

    public abstract void AskPreference();

    public void DisplayInfo()
    {
        Console.WriteLine($"Приятно познакомиться, {Name}. Ваш возраст {Age}. {GetPreferenceDescription()}");
    }

    protected abstract string GetPreferenceDescription();
}

class MalePerson : Person
{
    public MalePerson(string name, int age, string carBrand)
        : base(name, age, carBrand) {}

    public override void AskPreference()
    {
        Console.Write("Введите вашу любимую марку машины: ");
        PreferredThing = Console.ReadLine();
    }

    protected override string GetPreferenceDescription() => $"Любимая машина: {PreferredThing}";
}

class FemalePerson : Person
{
    public FemalePerson(string name, int age, string favoriteFlowers)
        : base(name, age, favoriteFlowers) {}

    public override void AskPreference()
    {
        Console.Write("Введите ваши любимые цветы: ");
        PreferredThing = Console.ReadLine();
    }

    protected override string GetPreferenceDescription() => $"Любимые цветы: {PreferredThing}";
}

class ChildPerson : Person
{
    public string FavoriteToy { get; set; }

    public ChildPerson(string name, int age, string favoriteToy) : base(name, age, favoriteToy)
    {
        FavoriteToy = favoriteToy;
    }

    protected override string GetPreferenceDescription() => $"Любимая игрушка: {PreferredThing}";

    public override void AskPreference()
    {
        Console.Write("Какая твоя любимая игрушка? ");
        FavoriteToy = Console.ReadLine();
    }
} 