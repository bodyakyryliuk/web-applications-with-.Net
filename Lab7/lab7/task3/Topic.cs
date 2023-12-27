namespace LinqExamples.task3;

public class Topic
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Topic(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
