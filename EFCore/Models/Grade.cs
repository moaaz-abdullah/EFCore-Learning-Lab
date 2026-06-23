using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore.Models
{
    public class Grade
    {
        [Key]
        public int Id { get; set; }

        public decimal Physics { get; set; }

        public decimal Chemistry { get; set; }

        public decimal Biology { get; set; }

        // Foreign key to Student
        [ForeignKey("Student")]
        public int StudentId { get; set; }
            
        // Navigation property to Student
        public Student Student { get; set; } = null!;
    }
}
