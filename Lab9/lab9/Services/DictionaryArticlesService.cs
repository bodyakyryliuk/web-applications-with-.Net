using lab9.DTO;
using lab9.Interfaces;
using lab9.Models;

namespace lab9.Services;

public class DictionaryArticlesService : IArticleService
{
    private readonly Dictionary<int, Article> articles = new Dictionary<int, Article>();
    private int nextId = 1;

    public List<Article> GetAllArticles()
    {
        foreach (var article in articles.Values)
        {
            Console.WriteLine(article.ToString());
        }
        return articles.Values.ToList();
    }

    public Article GetArticleById(int id)
    {
        articles.TryGetValue(id, out var article);
        return article;
    }

    public void CreateArticle(ArticleDto articleDto)
    {
        Article article = new Article(
            articleDto.Name, 
            articleDto.ExpirationDate, 
            articleDto.Category,
            articleDto.Description)
        {
            Id = nextId++
        };

        articles[article.Id] = article;
        Console.WriteLine("Article added: " + article.ToString());
    }

    public void UpdateArticleById(int id, Article updatedArticle)
    {
        if (!articles.ContainsKey(id))
        {
            throw new Exception("Article not found");
        }

        updatedArticle.Id = id;
        articles[id] = updatedArticle;
    }

    public void DeleteArticle(int id)
    {
        if (!articles.Remove(id))
        {
            throw new Exception("Article not found");
        }
    }
}