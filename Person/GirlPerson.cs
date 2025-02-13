class GirlPerson : Person
{
    private string PrefferedThingTitle = "Ваши любимые цветы: ";
    public override string getName(bool isGreating) 
    {
        return isGreating ? $"Г-жа. {Name}" : Name;
    }

    public override void askPreferense()
    {
        Console.Write(PrefferedThingTitle);
        string prefferedThingAswer = Console.ReadLine();
        PrefferedThing = $"{PrefferedThingTitle} {prefferedThingAswer}";
    }
}