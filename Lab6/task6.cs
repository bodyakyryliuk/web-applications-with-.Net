namespace lab_6;

public class task6
{
    private static (int evenIntCount, int positiveDoubleCount, int longStringCount, int otherCount) CountMyTypes(params object[] items)
    {
        int evenIntCount = 0, positiveDoubleCount = 0, longStringCount = 0, otherCount = 0;

        foreach (var item in items)
        {
            switch (item)
            {
                case int i when i % 2 == 0:
                    evenIntCount++;
                    break;
                case double d when d > 0:
                    positiveDoubleCount++;
                    break;
                case string s when s.Length >= 5:
                    longStringCount++;
                    break;
                default:
                    otherCount++;
                    break;
            }
        }

        return (evenIntCount, positiveDoubleCount, longStringCount, otherCount);
    }

    public static void Main()
    {
        var result = CountMyTypes(3, 5, 2, 2.2, 16, -4.2, 1.1, "hello", "hi", 7, -1.5, "world");
        Console.WriteLine($"Even Ints: {result.evenIntCount}, Positive Doubles: {result.positiveDoubleCount}, Long Strings: {result.longStringCount}, Others: {result.otherCount}");
    }
}