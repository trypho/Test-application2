class Student : Person
{

    private string _studentNum ="";
    private char _cfaculty = ' ';
    private string _course ="";
    private string _facultyName="";

    public Student(string name1, string surname1, string studNo,string gender,int age,string studCourse, char studFaculty)
    : base(name1,surname1,age,gender)
    {
       
        _studentNum = studNo;
        _cfaculty = studFaculty;
        _course = studCourse;
        _facultyName = GetFacultyName(_cfaculty);
    } 

    public void Details()
    {
        Console.WriteLine($"**************");
        Console.WriteLine($"\t\t\tStudent Details");
        Console.WriteLine($"Student number\t: {_studentNum}");
        Console.WriteLine($"Course\t\t: {_course}");
        Console.WriteLine($"Faculty\t\t: {_facultyName}");
        Console.WriteLine($"**************");
    }

    public string GetFacultyName(char cfaculty)
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
        get { return _studentNum; }
        set { _studentNum = value; }
    }

    public char Cfaculty
    {
        get { return _cfaculty; }
        set { _cfaculty = value; }
    }

    public string FacultyName
    {
        get { return _facultyName; }
        set { _facultyName = value; }
    }
}