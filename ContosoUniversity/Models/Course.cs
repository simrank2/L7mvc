////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Date         Name            Description
//2021-03-12   Simran Kaur     -creation of class Course in models folder

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-12-simrank2-dykstra2] - created a class that includes everything that's needed in a course
    public class Course
    {
        //tinfo200:[2021-03-12-simrank2-dykstra2] - attribute
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
