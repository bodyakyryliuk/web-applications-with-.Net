namespace LinqExamples;

public class task2
{
    public static void SortTopicsByFrequency()
    {
        var students = Generator.GenerateStudentsWithTopicsEasy();

        var topicFrequency = students
            .SelectMany(s => s.Topics)
            .GroupBy(topic => topic)
            .Select(group => new { Topic = group.Key, Count = group.Count() })
            .OrderByDescending(topic => topic.Count)
            .ThenBy(topic => topic.Topic)
            .ToList();

        Console.WriteLine("Topics sorted by frequency:");
        foreach (var topic in topicFrequency)
        {
            Console.WriteLine($"{topic.Topic} - Frequency: {topic.Count}");
        }
    }
    
    public static void SortTopicsByFrequencyWithinGender()
    {
        var students = Generator.GenerateStudentsWithTopicsEasy();

        var topicFrequencyByGender = students
            .GroupBy(student => student.Gender)
            .Select(genderGroup => new
            {
                Gender = genderGroup.Key,
                Topics = genderGroup
                    .SelectMany(s => s.Topics)
                    .GroupBy(topic => topic)
                    .Select(group => new { Topic = group.Key, Count = group.Count() })
                    .OrderByDescending(topic => topic.Count)
                    .ThenBy(topic => topic.Topic)
            })
            .ToList();

        foreach (var genderGroup in topicFrequencyByGender)
        {
            Console.WriteLine($"{genderGroup.Gender} Gender:");
            foreach (var topic in genderGroup.Topics)
            {
                Console.WriteLine($"  {topic.Topic} - Frequency: {topic.Count}");
            }
            Console.WriteLine();
        }
    }

}