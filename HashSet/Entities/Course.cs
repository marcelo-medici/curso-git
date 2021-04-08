using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet.Entities
{
    class Course
    {
        public HashSet<int> StudentID { get; set; }

        

        public Course()
        {
            StudentID = new HashSet<int>();
        }


        public bool AddStudent(int student)
        {
            return StudentID.Add(student);
        }

        public override int GetHashCode()
        {
            return StudentID.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Course other = (Course)obj;
            return obj is Course course && StudentID == other.StudentID;
        }
    }
}
