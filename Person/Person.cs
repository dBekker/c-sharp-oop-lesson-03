abstract class Person 
{
    public int Age;
    protected string Name;
    protected string PrefferedThing;

    abstract public string getName(bool isGreating);

    abstract public void askPreferense();

    public void setName(string name)
    {
        Name = name;
    }

    public string displayInfo()
    {
        return  $"Приятно познакомиться {getName(true)}! Ваш возраст - {Age}. {PrefferedThing}";
    }
}