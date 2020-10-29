using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;

namespace LigaUno.Utils
{
    class BaseDatos
    {

        public static OdbcConnection Cn;
        public static String Ssql;

        public static void SetConection() {
            string conexion = "Driver={MySQL ODBC 3.51 Driver};server=localhost;port=3306;Database=dbligauno;Uid=ligauno;Pwd=;";
            Cn = new OdbcConnection(conexion);
            if (Cn.State == ConnectionState.Open)
            {
                Cn.Close();
            }
            Cn.Open();
            Console.WriteLine("Se Conecto Todo Correcto");
        }

        public static OdbcDataReader GetDataReader(string Ssql)
        {
            OdbcCommand cmd = new OdbcCommand();
            cmd.Connection = Cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Ssql;
            return cmd.ExecuteReader();
        }

    }
}
