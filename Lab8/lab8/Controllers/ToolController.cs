using lab8.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab8.Controllers;

[ApiController]
[Route("[controller]")]
public class ToolController : Controller
{
    [HttpGet("Solve/{a}/{b}/{c}")]
    public ActionResult Solve(double a, double b, double c)
    {
        var solver = new QuadraticEquationSolver();
        var result = solver.Solve(a, b, c);
        string className;

        if (result.Root1 is Double.NaN)
        {
            ViewBag.className = "root-identity";
            ViewBag.Message = "There are infinite number of roots";

        }
        else if (result.Root1.HasValue && result.Root2.HasValue)
        {
            if (result.Root1 == result.Root2)
            {
                ViewBag.className = "root-one";
                ViewBag.Message = "There is one root: <br /> Root: " + result.Root1;
            }
            else
            {
                ViewBag.className = "root-two";
                ViewBag.Message = "There are two roots:<br />Root 1: " + result.Root1 + "<br />Root 2: " + result.Root2;
            }
        }
        else
        {
            ViewBag.className = "root-none";
            ViewBag.Message = "There is no root";
        }
        return View();
    }
}