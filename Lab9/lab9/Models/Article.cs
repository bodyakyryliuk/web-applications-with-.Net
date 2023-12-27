namespace lab9.Models;

public class Article
{
    private static int id = 0;
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime ExpirationDate { get; set; }
    public Category Category { get; set; }
    
    public string Description { get; set; }

    public Article(string name, DateTime expirationDate, Category category, string description)
    {
        Id = ++id;
        Name = name;
        ExpirationDate = expirationDate;
        Category = category;
        Description = description;
    }

    public Article()
    {
        Id = ++id;
    }

    public override string ToString()
    {
        return Id + " " + Name + " " + Description + " " + ExpirationDate;
    }
}