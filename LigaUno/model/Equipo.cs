using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaUno.model
{
    class Equipo
    {

        public int codequipo { get; set; }
        public String nombre { get; set; }
        public int puntos_totales { get; set; }
        public int goles_anotados { get; set; }
        public int goles_recibidos { get; set; }
        public int goles_totales { get; set; }
        public int partidos_ganados { get; set; }
        public int partidos_empatados { get; set; }
        public int partidos_perdidos { get; set; }
        public int partidos_totales { get; set; }

    }
}
