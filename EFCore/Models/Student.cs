using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; } = null!;

        public string Email { get; set; } = null!; 
        
        public int Age { get; set; }

        public int Grade { get; set; }
            
        public DateTime BirthDate { get; set; }

        // Navigation property for the related Grade entity
        public Grade GradeDetails { get; set; } = null!;

        [ForeignKey("Department")]
        public int DepartmentId { get; set; } // Foreign key for Department

        // Navigation property for the related Department entity
        public Department Department { get; set; } = null!;
    }
}
