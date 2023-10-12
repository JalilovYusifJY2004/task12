namespace task1210ok
{
    internal class Program
    {
      
        static void Main(string[] args)
        { 
            //task1
            Manager manager = new Manager("Yusif", true, 1150);
Assistant assistant = new Assistant("Sabir", true, 23466);

Console.WriteLine("Manager Salary: " + manager.Salary);
Console.WriteLine("Assistant Salary: " + assistant.Salary);

assistant.GetFeedback(manager);

Console.WriteLine("New Manager Salary: " + manager.Salary);






            
            // task2
        //    Student student = new Student();
        //    Console.Write("Enter student's name: ");
        //    student.Name = Console.ReadLine();

        //    Console.Write("Enter student's age: ");
        //    student.Age = int.Parse(Console.ReadLine());

        //    Console.Write("Enter student's grade: ");
        //    student.Grade = double.Parse(Console.ReadLine());

        //    Console.WriteLine($"Student Name: {student.Name}");
        //    Console.WriteLine($"Student Age: {student.Age}");
        //    Console.WriteLine($"Student Grade: {student.Grade}");
        //}
    }
        //task1
         class Manager : Employee
 {
     public Manager(string name, bool isSuccessful, int salary) : base(name, isSuccessful, salary) { }

     private void GetPromotion()
     {
         Salary += 100;
         Console.WriteLine($"{Name} : New Salary: {Salary}");
     }
     public Employee PromoteEmployee(Employee employee)
     {
         GetPromotion();
         return employee;
     }
 }

 class Assistant : Employee
 {
     public Assistant(string name, bool isSuccessful, int salary) : base(name, isSuccessful, salary) { }

     public void GetFeedback(Employee employee)
     {
         if (employee.IsSuccessful)
         {
             Console.WriteLine($"{Name} : Successful");
             Manager manager = employee as Manager;
             if (manager != null)
             {
                 manager.PromoteEmployee(employee);
             }
         }
         else
         {
             Console.WriteLine($"{Name} : Not Successful");
         }
     }
 }
 class Employee
 {
     public string Name { get; set; }
     public bool IsSuccessful { get; set; }
     public int Salary { get; set; }

     public Employee(string name, bool isSuccessful, int salary)
     {
         Name = name;
         IsSuccessful = isSuccessful;
         Salary = salary;
     }
 }














        
    //task2
    //class Student
    //{
    //    private string name;
    //    private int age;
    //    private double grade;

    //    public string Name
    //    {
    //        get { return name; }
    //        set
    //        {
    //            if (IsNameValid(value))
    //            {
    //                name = value;
    //            }
    //            else
    //            {
    //                Console.WriteLine("ad sevhdi");
    //            }
    //        }
    //    }
    //    private bool IsNameValid(string value)
    //    {
    //        if (!string.IsNullOrEmpty(value))
    //        {
    //            return false;
    //        }
    //        return true;
    //    }
    //    public int Age
    //    {
    //        get { return age; }
    //        set
    //        {
    //            if (IsAgeValid(value))
    //            {
    //                age = value;
    //            }
    //            else
    //            {
    //                Console.WriteLine("yas sevhdi");
    //            }
    //        }
    //    }
    //    private bool IsAgeValid(int value)
    //    {
    //        if (value <= 0)
    //        {
    //            return false;
    //        }
    //        return true;
    //    }
    //    public double Grade
    //    {
    //        get { return grade; }
    //        set
    //        {
    //            if (IsGradeValid(value))
    //            {
    //                grade = value;
    //            }
    //            else
    //            {
    //                Console.WriteLine("qiymet sevhdi");
    //            }
    //        }
    //    }
    //    private bool IsGradeValid(double value)
    //    {
    //        if (value < 0 || value > 100)
    //        {
    //            return false;
    //        }
    //        return true;
    //    }

    //}
    //class program
    //{
    //    static void Main(string[] args)
    //    {
    //        Student student = new Student();

    //        Console.Write("ad daxil et");
    //        student.Name = Console.ReadLine();
    //        Console.Write("yas daxil et");
    //        if (int.TryParse(Console.ReadLine(), out int value))
    //        {
    //            student.Age = value;
    //        }
    //        else
    //        {
    //            Console.WriteLine("yas sevhdi");
    //        }
    //        Console.Write("qiymet daxil et");
    //        if (double.TryParse(Console.ReadLine(), out double grade))
    //        {
    //            student.Grade = grade;
    //        }
    //        else
    //        {
    //            Console.WriteLine("qiymet sevhdi");
    //        }
    //        Console.WriteLine($"Ad:{student.Name},yas:{student.Age},qiymet:{student.Grade}");
    //    }
    }
}
