using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace imenik_app.Models
{
    public class Imenik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Priimek { get; set; }
        public string Naslov { get; set; }
        public string TelStevilka { get; set; }
    }
}
