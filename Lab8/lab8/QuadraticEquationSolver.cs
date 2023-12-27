using lab8.Models;

namespace lab8;

public class QuadraticEquationSolver
{
    public QuadraticEquationResult Solve(double a, double b, double c)
    {
        var result = new QuadraticEquationResult();

        if (a == 0 && b == 0 && c == 0)
        {
            result.Root1 = Double.NaN;
            result.Root2 = Double.NaN;
            result.Message = "Identity equation. Any value is a root.";
            return result;
        }
        
        double discriminant = b * b - 4 * a * c;
        if (discriminant < 0)
        {
            result.Message = "No roots.";
        }
        else if (discriminant == 0)
        {
            result.Root1 = result.Root2 = -b / (2 * a);
            result.Message = "One root.";
        }
        else
        {
            double sqrtDelta = Math.Sqrt(discriminant);
            result.Root1 = (-b + sqrtDelta) / (2 * a);
            result.Root2 = (-b - sqrtDelta) / (2 * a);
            result.Message = "Two roots.";
        }

        return result;
    }
}