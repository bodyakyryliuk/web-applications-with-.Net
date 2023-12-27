using Microsoft.AspNetCore.Mvc;

namespace lab8.Controllers;

[ApiController]
public class GameController : Controller
{
    private static int range = 0;
    private static int randValue = 0;
    private static int guessCount = 0;

    [HttpGet("Set,{n}")]
    public IActionResult Set(int n)
    {
        range = n;
        guessCount = 0;
        ViewBag.Range = n - 1;
        ViewBag.Message = $"Range set to 0-{n-1}. Draw value!";
        ViewBag.CssClassName = "info";
        return View("Guess");    }
    
    [HttpGet("Draw")]
    public IActionResult Draw()
    {
        if (range == 0)
        {
            ViewBag.CssClassName = "error";
            ViewBag.Message = "Set the range first using /Set,n";
        }
        else
        {
            randValue = new Random().Next(0, range);
            guessCount = 0;
            ViewBag.CssClassName = "info";
            ViewBag.Message = "The value is set. Start playing!";
        }

        return View("Guess");
    }
    
    [HttpGet("Guess,{guess}")]
    public IActionResult Guess(int guess)
    {
        if (range == 0)
        {
            ViewBag.CssClassName = "error";
            ViewBag.Message = "Set the range first";
        }
        else
        {
            guessCount++;
            if (guess < randValue)
            {
                ViewBag.CssClassName = "low";
                ViewBag.Message = $"Attempt {guessCount}: Too small. Try again.";
            }
            else if (guess > randValue)
            {
                ViewBag.CssClassName = "high";
                ViewBag.Message = $"Attempt {guessCount}: Too high! Try again.";
            }
            else
            {
                ViewBag.CssClassName = "success";
                ViewBag.Message =
                    $"Congratulations! You've guessed the number {randValue} correctly in {guessCount} attempts.";
                guessCount = 0;
            }
        }
        return View("Guess");
    }
}