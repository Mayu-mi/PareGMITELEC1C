namespace PareITELEC1C.Models
{
    public enum Course
    {
        BSIT, BSCS, BSIS
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public double GPA { get; set; }
        public Course Course { get; set; }
        public DateTime DateEnrolled { get; set; }
        
        public string Email { get; set; }
        public int InstructorId { get; internal set; }
        public string InstructorFirstName { get; set;}



    }
}
