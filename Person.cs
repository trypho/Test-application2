class Person
{
    protected string name;
    protected string surname;
    protected int age;
    protected string gender;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Surname
    {
        get { return surname; }
        set { surname = value; }
    }
    public string Gender
    {
        get { return gender; }
        set { gender = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public void PersonDetails()
    {
        Console.WriteLine("####################################");
        Console.WriteLine($"Name of the person\t: {name}");
        Console.WriteLine($"Surname\t: {surname}");
        Console.WriteLine($"Gender\t: {gender}");
        Console.WriteLine($"Age\t: {age}");
        Console.WriteLine("####################################");
    }

}