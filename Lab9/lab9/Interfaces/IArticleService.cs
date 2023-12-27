using lab9.DTO;
using lab9.Models;

namespace lab9.Interfaces;

public interface IArticleService
{
    List<Article> GetAllArticles();
    Article GetArticleById(int id);
    void CreateArticle(ArticleDto articleDto);
    void UpdateArticleById(int id, Article article);
    void DeleteArticle(int id);
}