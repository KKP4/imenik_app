using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace imenik_app.Models
{
    public class Kontakt
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Priimek { get; set; }
        public string Naslov { get; set; }
        public string TelStevilka { get; set; }
    }
    
}
