
namespace MyApplication
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tEnter the following details\n");
            Console.Write("Student Number: ");
            string? studNo = Console.ReadLine();

            Console.Write("Name: ");
            string? name = Console.ReadLine();

            Console.Write("Surname: ");
            string? surname = Console.ReadLine();

            Console.Write("Age: ");
            string? ageStr = Console.ReadLine();
            int age = int.Parse(ageStr);

            Console.Write("Gender: ");
            string? gender = Console.ReadLine();

            Console.Write("Faculty: ");
            string? facultyInput = Console.ReadLine();
            char faculty = !string.IsNullOrEmpty(facultyInput) ? facultyInput[0] : 'X';

            Console.Write("Course: ");
            string? course = Console.ReadLine();

            Student obj = new Student(name, surname, studNo, gender, age, course, faculty);
            obj.PersonDetails();
            obj.Details();
            obj.StudentNum = "0411025713081";
            obj.Cfaculty = 'e';
            obj.FacultyName = obj.GetFacultyName(obj.Cfaculty = 'H');
            obj.Details();
            Console.WriteLine($"Value of the cfaculty : {obj.Cfaculty}");
            Console.WriteLine($"Value of the FACULTY  : {obj.FacultyName}");


            Summary conclusion = new Summary();

            Console.WriteLine("><><><><><><><><");
            Console.WriteLine($"{conclusion.Comment}");
        }

    }
}
