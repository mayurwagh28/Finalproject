using System.ComponentModel.DataAnnotations.Schema;
namespace spms.Models
{
    [Table("Student")]
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }

        //[Column(TypeName = "Date")] // Specify the database column type
        public DateTime DOB { get; set; }

        public string Password { get; set; }
    }
}
