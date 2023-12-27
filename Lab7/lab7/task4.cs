using System.Reflection;

namespace LinqExamples;

public class Task4
{
    public static void task4()
    {
        string className = "LinqExamples.Department";
        Type departmentType = Type.GetType(className);
        ConstructorInfo constructor = departmentType.GetConstructor(new Type[] { typeof(int), typeof(string) });
        object departmentInstance = constructor.Invoke(new object[] { 1, "Computer Science" });


        MethodInfo methodInfo = typeof(Task4).GetMethod("DescribeDepartment", new[] { typeof(Department), typeof(int) });

        var result = methodInfo.Invoke(null, new object[] { departmentInstance, 5 });

        Console.WriteLine(result);
    }

    // Method to be invoked
    public static string DescribeDepartment(Department department, int number)
    {
        return $"Department ID: {department.Id}, Name: {department.Name}, Number: {number}";
    }
}
