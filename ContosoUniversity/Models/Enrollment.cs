////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Date         Name            Description
//2021-03-12   Simran Kaur     -creation of class Enrollment in models folder

namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-12-simrank2-dykstra2] - created class that includes everything that's needed/included in order for a student to enroll for a course
    public enum Grade
    {
        A, B, C, D, F
    }

    //tinfo200:[2021-03-12-simrank2-dykstra2] - Enrollments property = navigation property = hold other entities related to this entity
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        //tinfo200:[2021-03-12-simrank2-dykstra2] - ? = in the database, it can be null 
        //tinfo200:[2021-03-12-simrank2-dykstra2] - null = grade isn't known or hasn't been assigned yet
        public Grade? Grade { get; set; }
        public Student Student { get; set; }
    }
}