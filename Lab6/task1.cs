namespace lab_6;

public class task1
{
    private static void tuple()
    {
        (string Name, string Surname, int Age, double Salary) salaryTuple = ("Adam", "Abrams", 30, 5000.0); 
        printTuple(salaryTuple);
    }

    private static void printTuple((string, string, int, double) salaryTuple)
    {
        Console.WriteLine($"Employee: {salaryTuple.Item1} {salaryTuple.Item2} of age: {salaryTuple.Item3} has salary: {salaryTuple.Item4}");
        
        (string Name, string Surname, int Age, double Salary) namedInfo = salaryTuple;
        Console.WriteLine($"Employee: {namedInfo.Name} {namedInfo.Surname} of age: {namedInfo.Age} has salary: {namedInfo.Salary}");

        var (name, surname, age, salary) = salaryTuple;
        Console.WriteLine($"Employee: {name} {surname} of age: {age} has salary: {salary}");
    }

    public static void Main()
    {
        tuple();
    }

}