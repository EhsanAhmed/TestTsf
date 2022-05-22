using System.Collections.Generic;

namespace Day1.Models
{
    public class StudentList
    {
        List<Student> students = new List<Student>()
        {
            new Student (){ID=1, Name="Hossam", Address="assuit", Image="img4.jpg"},
            new Student (){ID=2, Name="Ahmed", Address="assuit", Image="img5.jpg"},
            new Student (){ID=3, Name="alaa", Address="assuit", Image="img6.jpg"}

        };

        public List<Student> StudentsFunc()
        {
            return students;    
        }
    }
}
