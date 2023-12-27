namespace lab_6;

public class task3
{
    public static void Main()
    {
        int[] array = {1, 3, 2, 5, 6, 4, 7, 4, 9};

        // Sort
        Array.Sort(array);
        printArray("Sorted array", array);
        
        // Binary search
        int index = Array.BinarySearch(array, 5);
        Console.WriteLine("Index of 5 element: " + index);

        // Copy
        int[] copyArray = new int[10];
        Array.Copy(array, copyArray, array.Length);
        printArray("Copied array", copyArray);

        // Reverse
        Array.Reverse(array);
        printArray("Reversed array", array);

        // IndexOf
        int indexOf9 = Array.IndexOf(array, 9);
        Console.WriteLine("Index of 9: " + indexOf9);
    }

    private static void printArray(String label, int[] array)
    {
        Console.Write(label + ": ");
        foreach (int num in array)
        {
            Console.Write(num + ", ");
        }
        Console.WriteLine();
    }
}