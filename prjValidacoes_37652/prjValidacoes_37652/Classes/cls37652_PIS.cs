using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj37652_PIS
{
    internal class cls37652_PIS
    {
        /// <summary>
        /// Método para validação de PIS/PASEP
        /// </summary>
        /// <param name="PIS"></param>
        /// <returns></returns>
        public static bool Validar(string PIS)
        {
            int mult = 3;
            int SN = 0;
            for (int i = 0; i < 10; i++)
            {
                SN += int.Parse(PIS.Substring(i, 1)) * mult;
                mult = mult == 2 ? 9 : mult-1;
            }
            int resto = SN % 11;
            int DV = 11 - resto;
            if(DV == 10 || DV == 11)
            {
                DV = 0;
            }

            if(PIS == new string(PIS[0], 11))
            {
                return false;
            }

            return DV.ToString() == PIS[10].ToString()? true:false;
        }
    }
}
