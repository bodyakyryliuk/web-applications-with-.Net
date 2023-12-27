namespace LinqExamples
{
    public class task1
    {
        public static void GroupStudents(int groupSize)
        {
            var students = Generator.GenerateStudentsWithTopicsEasy();

            var groupedStudents = students
                .OrderBy(s => s.Name)
                .ThenBy(s => s.Index)
                .Select((student, index) => new { Student = student, Group = index / groupSize })
                .GroupBy(x => x.Group)
                .ToList();

            foreach (var group in groupedStudents)
            {
                Console.WriteLine($"Group {group.Key + 1}:");
                foreach (var student in group)
                {
                    Console.WriteLine($"  {student.Student}");
                }
                Console.WriteLine();
            }
        }
    }
}