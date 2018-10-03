using System.Collections.Generic;

namespace DAL.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string GroupName { get; set; }

        public List<Student> GroupStudents { get; set; }
        public Teacher GroupTecher { get; set; }
    }
}
