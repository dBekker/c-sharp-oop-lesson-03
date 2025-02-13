class BoyPerson : Person
{
    public override string getName(bool isGreating) 
    {
        return isGreating ? $"Г-н. {Name}" : Name;
    }

    public override void askPreferense()
    {
        string PrefferedThingTitle = "Ваша любимая машина: ";
        Console.Write(PrefferedThingTitle);
        string prefferedThingAswer = Console.ReadLine();
        PrefferedThing = $"{PrefferedThingTitle} {prefferedThingAswer}";
    }
}