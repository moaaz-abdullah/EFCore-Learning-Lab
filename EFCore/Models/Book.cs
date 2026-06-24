using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace EFCore.Models
{
    public class Book
    {

        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Author { get; set; }

        public DateTime Created { get; set; }
    
        public ICollection<StudentBook> Students { get; set; } = new List<StudentBook>();
    }
}
