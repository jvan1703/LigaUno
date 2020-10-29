using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LigaUno.model;
using LigaUno.Utils;
using System.Data;
using System.Data.Odbc;

namespace LigaUno.controller
{
    class PartidoController
    {

        public static List<Partido> Select_by_codtorneo_codfecha(int p_codtorneo, int p_codfecha)
        {

            List<Partido> list = new List<Partido>();

            String Ssql = "SELECT partido.codpartido, elocal.nombre equipo_local, evisita.nombre equipo_visita,";
            Ssql = Ssql + " partido.goles_local, partido.goles_visita, partido.st_terminado FROM partido";
            Ssql = Ssql + " JOIN equipo elocal ON partido.codequipo_local = elocal.codequipo";
            Ssql = Ssql + " JOIN equipo evisita ON partido.codequipo_visita = evisita.codequipo";
            Ssql = Ssql + " WHERE partido.codtorneo = " + p_codtorneo + " AND partido.codfecha = " + p_codfecha + "; ";

            OdbcDataReader dr = BaseDatos.GetDataReader(Ssql);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Partido partido = new Partido();
                    partido.codpartido = dr.GetInt16(dr.GetOrdinal("codpartido"));
                    partido.elocal.nombre = dr.GetString(dr.GetOrdinal("equipo_local"));
                    partido.evisita.nombre = dr.GetString(dr.GetOrdinal("equipo_visita"));
                    partido.goles_local = dr.GetInt16(dr.GetOrdinal("goles_local"));
                    partido.goles_visita = dr.GetInt16(dr.GetOrdinal("goles_visita"));
                    partido.st_terminado = dr.GetInt16(dr.GetOrdinal("st_terminado"));
                    list.Add(partido);
                }
                return list;
            }
            else
            {
                return null;
            }

        }

        public static Partido Select_by_codtorneo_codfecha_codpartido(int p_codtorneo, int p_codfecha, int p_codpartido)
        {

            String Ssql = "SELECT partido.codpartido, partido.codequipo_local, elocal.nombre equipo_local, partido.codequipo_visita, evisita.nombre equipo_visita,";
            Ssql = Ssql + " partido.goles_local, partido.goles_visita, partido.st_terminado FROM partido";
            Ssql = Ssql + " JOIN equipo elocal ON partido.codequipo_local = elocal.codequipo";
            Ssql = Ssql + " JOIN equipo evisita ON partido.codequipo_visita = evisita.codequipo";
            Ssql = Ssql + " WHERE partido.codtorneo = " + p_codtorneo + " AND partido.codfecha = " + p_codfecha + " AND partido.codpartido = " + p_codpartido + ";";

            OdbcDataReader dr = BaseDatos.GetDataReader(Ssql);

            if (dr.HasRows)
            {
                dr.Read();
                Partido partido = new Partido();
                partido.codpartido = dr.GetInt16(dr.GetOrdinal("codpartido"));
                partido.codequipo_local = dr.GetInt16(dr.GetOrdinal("codequipo_local"));
                partido.elocal.nombre = dr.GetString(dr.GetOrdinal("equipo_local"));
                partido.codequipo_visita = dr.GetInt16(dr.GetOrdinal("codequipo_visita"));
                partido.evisita.nombre = dr.GetString(dr.GetOrdinal("equipo_visita"));
                partido.goles_local = dr.GetInt16(dr.GetOrdinal("goles_local"));
                partido.goles_visita = dr.GetInt16(dr.GetOrdinal("goles_visita"));
                partido.st_terminado = dr.GetInt16(dr.GetOrdinal("st_terminado"));
                return partido;
            }
            else
            {
                return null;
            }

        }

        public static bool Insert_update(Partido p_partido)
        {

            string Ssql = "";

            try
            {

                if (p_partido.codpartido == 0)
                {
                    Ssql = "SELECT IFNULL(MAX(partido.codpartido) + 1, 1) codpartido FROM partido";
                    Ssql = Ssql + " WHERE partido.codtorneo = " + p_partido.codtorneo + " AND partido.codfecha = " + p_partido.codfecha + "; ";
                    OdbcDataReader dr = BaseDatos.GetDataReader(Ssql);

                    if (dr.HasRows)
                    {
                        dr.Read();
                        p_partido.codpartido = dr.GetInt16(dr.GetOrdinal("codpartido"));
                    }
                }

                Ssql = "INSERT INTO partido(codtorneo, codfecha, codpartido, codequipo_local, codequipo_visita, goles_local, goles_visita, puntos_local,";
                Ssql = Ssql + " puntos_visita, tarjetas_amarillas_local, tarjetas_amarillas_visita, tarjetas_rojas_local, tarjetas_rojas_visita, st_terminado)";
                Ssql = Ssql + " VALUES(" + p_partido.codtorneo + ", " + p_partido.codfecha + ", " + p_partido.codpartido + ", " + p_partido.codequipo_local + ", " + p_partido.codequipo_visita + ", " + p_partido.goles_local + ", " + p_partido.goles_visita + ", " + p_partido.puntos_local + ",";
                Ssql = Ssql + " " + p_partido.puntos_visita + ", " + p_partido.tarjetas_amarillas_local + ", " + p_partido.tarjetas_amarillas_visita + ", " + p_partido.tarjetas_rojas_local + ", " + p_partido.tarjetas_rojas_visita + ", " + p_partido.st_terminado + ")";
                Ssql = Ssql + " ON DUPLICATE KEY UPDATE";
                Ssql = Ssql + " codequipo_local = " + p_partido.codequipo_local + ", codequipo_visita = " + p_partido.codequipo_visita + ", goles_local = " + p_partido.goles_local + ", ";
                Ssql = Ssql + " goles_visita = " + p_partido.goles_visita + ", puntos_local = " + p_partido.puntos_local + ", puntos_visita = " + p_partido.puntos_visita + ", ";
                Ssql = Ssql + " tarjetas_amarillas_local = " + p_partido.tarjetas_amarillas_local + ", tarjetas_amarillas_visita = " + p_partido.tarjetas_amarillas_visita + ", ";
                Ssql = Ssql + " tarjetas_rojas_local = " + p_partido.tarjetas_rojas_local + ", tarjetas_rojas_visita = " + p_partido.tarjetas_rojas_visita + ", ";
                Ssql = Ssql + " st_terminado = " + p_partido.st_terminado + ";";
                OdbcCommand cmd = new OdbcCommand(Ssql, BaseDatos.Cn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public static bool Delete(Partido p_partido)
        {

            String Ssql = "";

            try
            {
                Ssql = "DELETE FROM partido";
                Ssql = Ssql + " WHERE partido.codtorneo = " + p_partido.codtorneo + " AND partido.codfecha = "+ p_partido.codfecha +" AND partido.codpartido = "+ p_partido.codpartido +";";
                OdbcCommand cmd = new OdbcCommand(Ssql, BaseDatos.Cn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }

}
