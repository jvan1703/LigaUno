using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaUno.model
{
    class Partido
    {
        public int codtorneo { get; set; }
        public int codfecha { get; set; }
        public int codpartido { get; set; }
        public int codequipo_local { get; set; }
        public int codequipo_visita { get; set; }
        public int goles_local { get; set; }
        public int goles_visita { get; set; }
        public int puntos_local { get; set; }
        public int puntos_visita { get; set; }
        public int tarjetas_amarillas_local { get; set; }
        public int tarjetas_amarillas_visita { get; set; }
        public int tarjetas_rojas_local { get; set; }
        public int tarjetas_rojas_visita { get; set; }
        public int st_terminado { get; set; }
        public Torneo torneo { get; set; }
        public Fecha fecha { get; set; }
        public Equipo elocal { get; set; }
        public Equipo evisita { get; set; }

        public Partido() {
            torneo = new Torneo();
            fecha = new Fecha();
            elocal = new Equipo();
            evisita = new Equipo();
        }

        public Partido(int codtorneo, int codfecha, int codpartido)
        {
            torneo = new Torneo();
            fecha = new Fecha();
            elocal = new Equipo();
            evisita = new Equipo();
            this.codtorneo = codtorneo;
            this.codfecha = codfecha;
            this.codpartido = codpartido;
        }

    }
}
