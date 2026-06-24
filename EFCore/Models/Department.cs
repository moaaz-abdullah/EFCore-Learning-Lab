using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace EFCore.Models
{
    public class Department
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Department name is required")]
        public string Name { get; set; } = null!;

        [MaxLength(20, ErrorMessage = "Description cannot exceed 20 characters")]
        public string Description { get; set; }

        // Navigation property for the related Student entity
        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
