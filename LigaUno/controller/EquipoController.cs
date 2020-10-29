using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LigaUno.model;
using System.Data.Odbc;
using LigaUno.Utils;

namespace LigaUno.controller
{
    class EquipoController
    {

        public static List<Equipo> select_for_tabla_acumulada() {

            List<Equipo> list = new List<Equipo>();

            String Ssql = "SELECT codequipo, nombre, puntos_totales, goles_anotados, goles_recibidos, goles_totales, partidos_ganados, partidos_empatados, partidos_perdidos, partidos_totales FROM equipo";
            Ssql = Ssql + " ORDER BY puntos_totales desc, goles_totales desc, nombre asc;";

            OdbcDataReader dr = BaseDatos.GetDataReader(Ssql);

            if (dr.HasRows) 
            {
                while (dr.Read()) {
                    Equipo equipo = new Equipo();
                    equipo.codequipo = dr.GetInt16(dr.GetOrdinal("codequipo"));
                    equipo.nombre = dr.GetString(dr.GetOrdinal("nombre"));
                    equipo.puntos_totales = dr.GetInt16(dr.GetOrdinal("puntos_totales"));
                    equipo.goles_anotados = dr.GetInt16(dr.GetOrdinal("goles_anotados"));
                    equipo.goles_recibidos = dr.GetInt16(dr.GetOrdinal("goles_recibidos"));
                    equipo.goles_totales = dr.GetInt16(dr.GetOrdinal("goles_totales"));
                    equipo.partidos_ganados = dr.GetInt16(dr.GetOrdinal("partidos_ganados"));
                    equipo.partidos_empatados = dr.GetInt16(dr.GetOrdinal("partidos_empatados"));
                    equipo.partidos_perdidos = dr.GetInt16(dr.GetOrdinal("partidos_perdidos"));
                    equipo.partidos_totales = dr.GetInt16(dr.GetOrdinal("partidos_totales"));
                    list.Add(equipo);
                }
                return list;
            }
            else {
                return null;
            }
            
        }

        public static List<Equipo> select()
        {

            List<Equipo> list = new List<Equipo>();

            String Ssql = "SELECT codequipo, nombre FROM equipo";
            Ssql = Ssql + " ORDER BY nombre;";

            OdbcDataReader dr = BaseDatos.GetDataReader(Ssql);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Equipo equipo = new Equipo();
                    equipo.codequipo = dr.GetInt16(dr.GetOrdinal("codequipo"));
                    equipo.nombre = dr.GetString(dr.GetOrdinal("nombre"));
                    list.Add(equipo);
                }
                return list;
            }
            else
            {
                return null;
            }

        }

        public static bool Calcular_tabla_acumulada() {
            try{
                String Ssql = "CALL calcular_table_acumulada();";
                OdbcCommand cmd = new OdbcCommand(Ssql, BaseDatos.Cn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception){
                return false;
            }
        }

    }
}
