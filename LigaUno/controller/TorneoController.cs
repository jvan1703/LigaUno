using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using LigaUno.model;
using LigaUno.Utils;

namespace LigaUno.controller
{
    class TorneoController
    {
        public static List<Torneo> Select() {

            List<Torneo> list = new List<Torneo>();

            String Ssql = "SELECT codtorneo, nombre FROM torneo;";

            OdbcDataReader dr = BaseDatos.GetDataReader(Ssql);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Torneo torneo = new Torneo();
                    torneo.codtorneo = dr.GetInt16(dr.GetOrdinal("codtorneo"));
                    torneo.nombre = dr.GetString(dr.GetOrdinal("nombre"));
                    list.Add(torneo);
                }
                return list;
            }
            else
            {
                return null;
            }

        }
    }
}
