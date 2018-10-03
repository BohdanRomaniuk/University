namespace DAL.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public double AvgMark { get; set; }
        public int StudyYear { get; set; }

        public Student()
        {
        }

        public Student(string name, string surName, double avgMark, int studyYear)
        {
            Name = name;
            Surname = surName;
            AvgMark = avgMark;
            StudyYear = studyYear;
        }
    }
}
