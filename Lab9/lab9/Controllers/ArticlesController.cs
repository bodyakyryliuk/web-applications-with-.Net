using lab9.DTO;
using lab9.Interfaces;
using lab9.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab9.Controllers;

[Route("[controller]")]
public class ArticlesController : Controller
{
    private readonly IArticleService _articleService;

    public ArticlesController(IArticleService articleService)
    {
        this._articleService = articleService;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        List<Article> articles = _articleService.GetAllArticles();
        foreach (var article in articles)
        {
            Console.WriteLine(article.ToString());
        }
        return View("~/Views/Articles/Index.cshtml",articles);
    }
    
    [HttpGet("details/{id}")]
    public IActionResult Details(int id)
    {
        var article = _articleService.GetArticleById(id);
        if (article == null)
        {
            return NotFound();
        }
        return View(article);
    }

    [HttpPost("create")]
    public IActionResult CreateArticle(ArticleDto articleDto)
    {
        if (ModelState.IsValid)
        {
            _articleService.CreateArticle(articleDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Home/_CreateArticle.cshtml",articleDto);
    }

    public ActionResult Edit(int id)
    {
        var article = _articleService.GetArticleById(id);

        return View(article);
    }

    [HttpPost]
    public ActionResult Edit(Article article)
    {
        if (ModelState.IsValid)
        {
            _articleService.UpdateArticleById(article.Id, article);
            return RedirectToAction("Index"); // Redirect to the list view
        }
        return View(article);
    }

    [HttpPost("delete")]
    public IActionResult Delete(int id)
    {
        _articleService.DeleteArticle(id);

        return Index();
    }
}