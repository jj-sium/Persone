using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ghinelli.johan._4h.persone.Models
{
    public enum TipoPersona { NonDefinitp, ATA, Alunno, Docente };
    public class Persona
    {
        public TipoPersona Tipo{ get; set; }

        public string Nome { get; set; }

        public string Cognome { get; set; }

        public string Email { get; set; }

        public class ATA : Persona
        {
            public ATA()
            {
                Tipo = TipoPersona.ATA;
            }
        }
    }
}
