using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.Models
{
    public class Department
    {
        public int ID { get; set; }

        public string Name { get; set; } = null!;
    }
}
