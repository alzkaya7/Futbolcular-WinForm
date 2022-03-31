using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbol.Model
{
    internal class Takımlar
    {

        public int TakımID { get; set; }
        public string TakımAdı { get; set; }
        public string Stadyum { get; set; }
        public string TakımResim { get; set; }
        public int LigID { get; set; }
    }
}
