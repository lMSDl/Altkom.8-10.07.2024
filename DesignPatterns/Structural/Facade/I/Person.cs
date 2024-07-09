using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._8_10._07._2024.DesignPatterns.Structural.Facade.I
{
    internal class Person
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Id { get; set; }

        public int Age => DateTime.Now.Year - BirthDate.Year;
    }
}
