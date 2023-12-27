namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            while (true)
            {
                Console.WriteLine("Please enter a");
                if (double.TryParse(Console.ReadLine(), out a))
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            while (true)
            {
                Console.WriteLine("Please enter b");
                if (double.TryParse(Console.ReadLine(), out b))
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            while (true)
            {
                Console.WriteLine("Please enter c");
                if (double.TryParse(Console.ReadLine(), out c))
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
            var d = b * b - 4 * a * c;
            if (d < 0)
            {
                Console.WriteLine("There is no solution");
            }
            else if (d == 0)
            {
                var x = (-b - double.Sqrt(d)) / 2 * a;
                Console.WriteLine("The result is: {0}", x);
            }
            else
            {
                var x1 = (-b - double.Sqrt(d)) / 2 * a;
                var x2 = (-b + double.Sqrt(d)) / 2 * a;
                Console.WriteLine($"The result is: {x1}; {x2}");
            }
            {
                
            }
        }
    }
}