using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaUno.utils
{
    class H
    {
        public static int CInt(String valor) {
            try
            {
                int x = Convert.ToInt32(valor);
                return x;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
