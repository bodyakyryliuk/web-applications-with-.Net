namespace lab_6;

public class task5
{
    private static void DrawCard(string line1, string line2 = "", char borderChar = 'X', int borderWidth = 2, int minWidth = 20)
    {
        int maxLineWidth = Math.Max(line1.Length, line2.Length);
        int cardWidth = Math.Max(minWidth, maxLineWidth + 2 * borderWidth);

        string CreateLine(string text)
        {
            int padding = (cardWidth - text.Length - 2 * borderWidth) / 2;
            string linePadding = new string(' ', padding);
            string line = borderChar.ToString().PadLeft(borderWidth, borderChar) +
                          linePadding + text + linePadding;
            if ((cardWidth - text.Length) % 2 != 0) line += " ";
            line += borderChar.ToString().PadLeft(borderWidth, borderChar);
            return line;
        }

        // Top border
        string border = new string(borderChar, cardWidth);
        Console.WriteLine(border);
        Console.WriteLine(border);

        // Text lines
        Console.WriteLine(CreateLine(line1));
        if (!string.IsNullOrEmpty(line2))
        {
            Console.WriteLine(CreateLine(line2));
        }

        // Bottom border
        Console.WriteLine(border);
        Console.WriteLine(border);
    }

    public static void Main()
    {
        Console.WriteLine();
        DrawCard("Bohdan", "Kyryliuk", 'X', 2, 20);
        Console.WriteLine();
        DrawCard("Bohdan", "Kyryliuk");
        Console.WriteLine();
        DrawCard("Bohdan", borderChar: '*', borderWidth: 3, minWidth: 25);
        Console.WriteLine();
        DrawCard(line1: "Bohdan", line2: "Kyryliuk", minWidth: 30);
    }
}