using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore.Models
{
    [Table("StudentAttendances", Schema = "std")]
    public class Attendance
    {
        [Key]
        public int Id { get; set; }

        [Column("NameOfTheDay", TypeName = "nvarchar(20)")]
        public string DayName { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }

        // Navigation property to Student
        public Student Student { get; set; }

        [NotMapped] // This property will not be mapped to the database
        public DateTime Date { get; set; }

    }
}
