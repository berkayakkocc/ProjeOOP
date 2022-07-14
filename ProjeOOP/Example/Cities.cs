using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeOOP.Example
{
    public class Cities:Flag// Kalıtım-Inheritance
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int Population { get; set; }
        public int CountYear { get; set; }

    }
}
