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

        public string DayName { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }

        // Navigation property to Student
        public Student Student { get; set; }

    }
}
