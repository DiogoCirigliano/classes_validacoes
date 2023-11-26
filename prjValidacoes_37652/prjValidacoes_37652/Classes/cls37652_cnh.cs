using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj37652_cnh
{
    internal class cls37652_cnh
    {
        /// <summary>
        /// recebe string cnh e retorna bool
        /// </summary>
        /// <param name="cnh"></param>
        /// <returns></returns>
        public static bool Validar(string cnh)
        {
            #region Primeiro DV
            int mult = 2;
            int sm = 0;
            for (int i = 0; i < 9; i++)
            {
                sm += int.Parse(cnh.Substring(i, 1)) * mult;
                mult++;
            }
            int resto = sm % 11;
            int DV1 = 11 - resto;
            if (DV1 > 9) { DV1 = 0; }
            #endregion

            #region Segundo DV
            mult = 3;
            sm = 0; 
            for (int i = 0; i < 9; i++)
            {
                sm += int.Parse(cnh.Substring(i, 1)) * mult;
                mult++;
            }
            sm += DV1 * 2; 
            resto = sm % 11;
            int DV2 = 11 - resto;
            if (DV2 > 9) { DV2 = 0; }
            #endregion

            return DV1 == int.Parse(cnh[9].ToString()) && DV2 == int.Parse(cnh[10].ToString());
        }

    }
}
