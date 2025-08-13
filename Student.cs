class Student : Person
{

    private string studentNum;
    private char cfaculty;
    private string course;
    private string facultyName;

    public Student(string name1, string surname1, string studNo,string gender,int age,string studCourse, char studFaculty)
    {
        base.Name= name1;
        base.surname= surname1;
        studentNum = studNo;
        base.Age = age;
        base.Gender = gender;
        cfaculty = studFaculty;
        course = studCourse;
        facultyName = Faculty(cfaculty);
    }

    public void Details()
    {
        Console.WriteLine($"**************");
        Console.WriteLine($"\t\t\tStudent Details");
        Console.WriteLine($"Student number\t: {studentNum}");
        Console.WriteLine($"Course\t\t: {course}");
        Console.WriteLine($"Faculty\t\t: {facultyName}");
        Console.WriteLine($"**************");
    }

    public string Faculty(char cfaculty)
    {
        string facName = "";
        if (char.ToUpper(cfaculty) == 'I')
        {
            facName = "ICT";
        }
        else if (char.ToUpper(cfaculty) == 'H')
        {
            facName = "HUMANITIES";
        }
        else if (char.ToUpper(cfaculty) == 'E')
        {
            facName = "ECONOMICS AND FINANCE";
        }
        else if (char.ToUpper(cfaculty) == 'M')
        {
            facName = "MANAGEMENT SCIENCE";
        }
        else
        {
            facName = "N/A";
        }

        return facName;

    }

    public string StudentNum
    {
        get { return studentNum; }
        set { studentNum = value; }
    }

    public char Cfaculty
    {
        get { return cfaculty; }
        set { cfaculty = value; }
    }

    public string FacultyName
    {
        get { return facultyName; }
        set { facultyName = value; }
    }
}