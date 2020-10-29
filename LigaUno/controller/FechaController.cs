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
    class FechaController
    {
        public static List<Fecha> Select_by_codtorneo(int p_codtorneo)
        {

            List<Fecha> list = new List<Fecha>();

            String Ssql = "SELECT codfecha, descripcion FROM fecha WHERE codtorneo = "+ p_codtorneo +";";

            OdbcDataReader dr = BaseDatos.GetDataReader(Ssql);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Fecha fecha = new Fecha();
                    fecha.codfecha = dr.GetInt16(dr.GetOrdinal("codfecha"));
                    fecha.descripcion = dr.GetString(dr.GetOrdinal("descripcion"));
                    list.Add(fecha);
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
