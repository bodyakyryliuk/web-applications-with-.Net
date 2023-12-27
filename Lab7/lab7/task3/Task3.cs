namespace LinqExamples.task3;

public class Task3
{
    public static List<Student> TransformToStudents(List<StudentWithTopics> studentWithTopicsList)
    {
        // Minimalist: Defining a list of topics in the code
        var topics = new List<Topic>
        {
            new Topic(1, "C#"),
            new Topic(2, "C++"),
            new Topic(3, "PHP"),
            new Topic(4, "Java"),
            new Topic(5, "algorithms"),
            new Topic(6, "fuzzy logic"),
            new Topic(7, "neural networks"),
            new Topic(8, "web programming"),
            new Topic(9, "Basic"),
            new Topic(10, "JavaScript")
        };

        // Creating a mapping from topic names to their IDs
        Dictionary<string, int> topicNameToIdMap = topics.ToDictionary(t => t.Name, t => t.Id);

        // Transforming StudentWithTopics to Student
        List<Student> students = studentWithTopicsList.Select(swt => new Student
        {
            Id = swt.Id,
            Index = swt.Index,
            Name = swt.Name,
            Gender = swt.Gender,
            Active = swt.Active,
            DepartmentId = swt.DepartmentId,
            // Mapping the topic names to IDs
            TopicIds = swt.Topics.Select(t => topicNameToIdMap.ContainsKey(t) ? topicNameToIdMap[t] : -1).ToList()
        }).ToList();

        return students;
    }

    
    public static List<Student> TransformToStudentsWithGeneratedTopics(List<StudentWithTopics> studentWithTopicsList)
    {
        // Extracting unique topic names from StudentWithTopics objects
        var uniqueTopicNames = studentWithTopicsList
            .SelectMany(swt => swt.Topics)
            .Distinct()
            .ToList();

        // Assigning each unique topic a unique ID
        var topics = uniqueTopicNames
            .Select((name, index) => new Topic(index + 1, name))
            .ToList();

        var topicNameToIdMap = topics.ToDictionary(t => t.Name, t => t.Id);

        // Transforming StudentWithTopics objects into Student objects
        return studentWithTopicsList.Select(swt => new Student(
            swt.Id, swt.Index, swt.Name, swt.Gender, swt.Active, swt.DepartmentId,
            swt.Topics.Select(topicName => topicNameToIdMap[topicName]).ToList()
        )).ToList();
    }



}