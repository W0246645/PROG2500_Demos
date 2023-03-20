public partial class Program
{
    public class Student
    {
        public int ID { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public List<int> Scores { get; set; }
    }

    // Create a data source by using a collection initializer.
    static List<Student> students = new List<Student>
    {
        new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81, 60}},
        new Student {First="Claire", Last="O'Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}},
        new Student {First="Sven", Last="Mortensen", ID=113, Scores= new List<int> {88, 94, 65, 91}},
        new Student {First="Cesar", Last="Garcia", ID=114, Scores= new List<int> {97, 89, 85, 82}},
        new Student {First="Debra", Last="Garcia", ID=115, Scores= new List<int> {35, 72, 91, 70}},
        new Student {First="Fadi", Last="Fakhouri", ID=116, Scores= new List<int> {99, 86, 90, 94}},
        new Student {First="Hanying", Last="Feng", ID=117, Scores= new List<int> {93, 92, 80, 87}},
        new Student {First="Hugo", Last="Garcia", ID=118, Scores= new List<int> {92, 90, 83, 78}},
        new Student {First="Lance", Last="Tucker", ID=119, Scores= new List<int> {68, 79, 88, 92}},
        new Student {First="Terry", Last="Adams", ID=120, Scores= new List<int> {99, 82, 81, 79}},
        new Student {First="Eugene", Last="Zabokritski", ID=121, Scores= new List<int> {96, 85, 91, 60}},
        new Student {First="Michael", Last="Tucker", ID=122, Scores= new List<int> {94, 92, 91, 91}}
    };

    static void Main(string[] args)
    {
        //1. Create a LINQ query
        //2. Ordering results
        
        ////Sad way
        //var studentQuery = 
        //    from student in students
        //    where student.Scores[0] > 90
        //    orderby student.Last descending
        //    select student;

        //foreach (var student in studentQuery)
        //{
        //    Console.WriteLine("{0}, {1}", student.Last, student.First);
        //}


        ////Happy way
        //var studentList = students.Where(student => student.Scores[0] > 90).ToList().OrderByDescending(student => student.Last);

        //foreach (var student in studentList) { 
        //    Console.WriteLine("{0}, {1}", student.Last, student.First);
        //}

        //3. Grouping the results
        var studentQuery2 =
            from student in students
            group student by student.Last[0];

        foreach (var group in studentQuery2) 
        {
            Console.WriteLine(group.Key);
            foreach (var student in group)
            {
                Console.WriteLine("    {0}, {1}", student.Last, student.First);
            }
        }
    }
}