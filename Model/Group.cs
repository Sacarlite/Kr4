
using System.ComponentModel.DataAnnotations;

namespace Kr4
{
    public class StudentGroup
    {

        public StudentGroup(string group)
        {

            Group = group;
        }

        [Required]
        public int Id { get; set; }
        [Required]
        public string Group { get; set; }
        public List<Student> Students { get; set; } = new();
    }
}
