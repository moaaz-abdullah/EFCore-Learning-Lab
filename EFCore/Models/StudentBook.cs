using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore.Models
{
    public class StudentBook
    {
        public int Id { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }

        public Student Student { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }

        public Book Book { get; set; }

        public DateTime GetDate { get; set; }
    }
}
