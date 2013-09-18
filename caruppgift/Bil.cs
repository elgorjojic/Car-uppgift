using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caruppgift
{
    class Bil
    {
        public string Marke { get; set; }
        public int Arsmodell { get; set; }

        public Bil(string marke, int arsmodell)
        {
            Marke = "Volvo";
            Arsmodell = 1965;
        }
    }
}
