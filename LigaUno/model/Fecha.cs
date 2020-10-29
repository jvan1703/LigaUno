using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaUno.model
{
    class Fecha
    {
        public int codtorneo { get; set; }
        public int codfecha { get; set; }
        public String descripcion { get; set; }
        public DateTime fecini { get; set; }
        public DateTime fecfin { get; set; }
        public Torneo torneo { get; set; }
        public Fecha() {
            torneo = new Torneo();
        }
       
    }
}
