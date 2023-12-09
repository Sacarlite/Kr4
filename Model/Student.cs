using System.ComponentModel.DataAnnotations;

namespace Kr4
{
    public class Student
    {
        public Student(string? studentName, string? studentSurname, string? studentMidlename, bool gender, DateTime birthday)
        {
            StudentName = studentName;
            StudentSurname = studentSurname;
            StudentMidlename = studentMidlename;
            Gender = gender;
            Birthday = birthday;
        }

        public int Id { get; set; }
        [Required]
        public string? StudentName { get; set; }
        [Required]
        public string? StudentSurname { get; set; }
        [Required]
        public string? StudentMidlename { get; set; }

        public bool Gender { get; set; }
        public DateTime Birthday { get; set; }

        public int IdGroup { get; set; }
        public StudentGroup? Group { get; set; }

    }
}
