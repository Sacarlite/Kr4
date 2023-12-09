
using Kr4.Properties;
using Microsoft.EntityFrameworkCore;


namespace Kr4
{
    public static class ConectString
    {
        public static string conectionString;
    }
    public class ApplicationContext : DbContext
    {

        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<StudentGroup> StudentGroups { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder )
        {
            optionsBuilder.UseSqlite(ConectString.conectionString);
                 
        }
    }
    public class DbManager {
        public static void AddGroupToStudent(Student student,string groupName) {
            using (ApplicationContext db = new ApplicationContext())
            {
                StudentGroup? gr = db.StudentGroups.FirstOrDefault(p => p.Group == groupName);
                student.Group= gr;
                db.Students.Add(student);
                db.SaveChanges();
            }
        }
        public static bool CheckGroupExist(string groupName)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                StudentGroup? gr = db.StudentGroups.FirstOrDefault(p => p.Group == groupName);
                if(gr != null) { return true; }
                return false;
            }
        }
        public static void AddGroup(string groupName)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                StudentGroup? gr = new StudentGroup(groupName);
                db.StudentGroups.Add(gr);
                db.SaveChanges();
            }
        }
        public static List<Student> GetStudentList()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
                return db.Students.Include(u => u.Group).ToList(); 
            }
        }
        public static Student GetStudent(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
                return db.Students.Include(u => u.Group).Where(u => u.Id == id).First();
            }
        }
        public static void ChangeStudent(Student student, string groupName,Student newStudent)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
                var stud = db.Students.Include(u => u.Group).Where(u => u.Id == student.Id).First();
                StudentGroup? gr = db.StudentGroups.FirstOrDefault(p => p.Group == groupName);
                stud.StudentName= newStudent.StudentName;
                stud.StudentSurname= newStudent.StudentSurname;
                stud.StudentMidlename= newStudent.StudentMidlename;
                stud.Birthday= newStudent.Birthday;
                stud.Gender = newStudent.Gender;
                stud.Group = gr;
                db.SaveChanges();
            }
        }
        public static void DeleteStudent(Student student)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
                var stud = db.Students.Include(u => u.Group).Where(u => u.Id == student.Id).First();
                db.Students.Remove(stud);
                db.SaveChanges();
            }
        }
        public static List<StudentGroup> GetGroupList()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
                return db.StudentGroups.ToList();
            }
        }
        public static List<Student> GetStudentsGroupX(string group)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Students.Include(u => u.Group).Where(u => u.Group!.Group == group).ToList();
            }
        }
        public static List<Student> GetStudentsGenderX(bool gender)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Students.Include(u => u.Group).Where(u => u.Gender== gender).ToList();
            }
        }
        public static List<Student> GetStudentsGroupAndGenderX(string group, bool gender)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Students.Include(u => u.Group).Where(u => u.Group!.Group == group && u.Gender == gender).ToList();
            }
        }
        public static void RemoveDb()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureDeleted();
            }
        }
        public static void CreateDb()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
            }
        }

    }
}
