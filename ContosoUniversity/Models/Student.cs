////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Date         Name            Description
//2021-03-12   Simran Kaur     -creation of class Student in models folder

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-12-simrank2-dykstra2] - creation of class that includes what makes up a student 
    public class Student
    {
        //tinfo200:[2021-03-12-simrank2-dykstra2] - properties 
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
