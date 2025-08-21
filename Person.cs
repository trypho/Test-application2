class Person
{
    protected string _name;
    protected string _surname;
    protected int _age;
    protected string _gender;

    public Person(string name, string surname, int age, string gender)
    {
        _name = name;
        _surname = surname;
        _age = age;
        _gender = gender;
    }
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string Surname
    {
        get { return _surname; }
        set { _surname = value; }
    }
    public string Gender
    {
        get { return _gender; }
        set { _gender = value; }
    }
    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

    public void PersonDetails()
    {
        Console.WriteLine("####################################");
        Console.WriteLine($"Name of the person\t: {_name}");
        Console.WriteLine($"Surname\t\t\t: {_surname}");
        Console.WriteLine($"Gender\t\t\t: {_gender}");
        Console.WriteLine($"Age\t\t\t: {_age}");
        Console.WriteLine("####################################");
    }

}