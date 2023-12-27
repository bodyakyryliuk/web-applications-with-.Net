namespace lab_6;

public class task4
{
    private static void ProcessEmployee()
    {
        // Creating an anonymous type
        var employee = new { Name = "Adam", Surname = "Abrams", Age = 30, Salary = 5000.0 };

        printTuple(employee);
    }
    
    private static void printTuple(dynamic salaryTuple)
    {
        Console.WriteLine($"Employee: {salaryTuple.Name} {salaryTuple.Surname} of age: {salaryTuple.Age} has salary: {salaryTuple.Salary}");
        
    }

    public static void Main()
    {
        ProcessEmployee();
    }

}