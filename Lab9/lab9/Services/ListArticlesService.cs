using lab9.DTO;
using lab9.Interfaces;
using lab9.Models;

namespace lab9.Services;

public class ListArticlesService : IArticleService{
    private readonly List<Article> articles = new List<Article>();

    public List<Article> GetAllArticles()
    {
        foreach (Article article in articles)
        {
            Console.WriteLine(article.ToString());
        }
        return articles;
    }

    public Article GetArticleById(int id)
    {
        return articles.FirstOrDefault(article => article.Id == id);
    }

    public void CreateArticle(ArticleDto articleDto)
    {
        Article article = new Article(
            articleDto.Name, 
            articleDto.ExpirationDate, 
            articleDto.Category,
            articleDto.Description);
        
        articles.Add(article);
        Console.WriteLine("Article added: " + article.ToString());
        foreach (Article article1 in articles)
        {
            Console.WriteLine(article1.ToString() + " articles in collection");
        }
    }

    public void UpdateArticleById(int id, Article updatedArticle)
    {
        var article = articles.FirstOrDefault(article => article.Id == id);
        if (article == null)
        {
            throw new Exception("Article not found");
        }

        article.Category = updatedArticle.Category;
        article.Name = updatedArticle.Name;
        article.ExpirationDate = updatedArticle.ExpirationDate;
        article.Description = updatedArticle.Description;
    }

    public void DeleteArticle(int id)
    {
        var article = articles.FirstOrDefault(article => article.Id == id);
        if (article == null)
        {
            throw new Exception("Article not found");
        }

        articles.Remove(article);
    }
}