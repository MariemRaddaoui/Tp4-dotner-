using System.ComponentModel.DataAnnotations;

namespace TP4.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String PhoneNumber { get; set; }
        public String University { get; set; }
        public String Timestamp { get; set; }
        public String Course { get; set; }

        public Student(int id, string firstName, string lastName, string phoneNumber, string university, string timestamp, string course)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.University = university;
            this.Timestamp = timestamp;
            this.Course = course;
        }
    }
}