using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Models
{
    // Index attribute to create an index on the Name property
    // [Index("Name", IsUnique = true)]
    public class Student
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; } = null!;

        public string Email { get; set; } = null!;

        public int Age { get; set; }

        public int Grade { get; set; }

        public DateTime BirthDate { get; set; }

        //// Navigation property for the related Attendance entity
        //public Attendance Attendance { get; set; } = null!;

        // Navigation property for the related Grade entity
        public Grade GradeDetails { get; set; } = null!;

        // Navigation property for the related Department entity
        public Department Department { get; set; } = null!;

        [ForeignKey("Department")]  // Foreign key for Department
        public int DepartmentId { get; set; }

        public ICollection<StudentBook> Books { get; set; } = new List<StudentBook>();

        public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

        public int DeliveryOrder { get; set; }
    }
}
