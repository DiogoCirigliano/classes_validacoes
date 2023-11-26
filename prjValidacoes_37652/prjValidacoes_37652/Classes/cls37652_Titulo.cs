using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj37652_Titulo
{
    internal class cls37652_Titulo
    {
        /// <summary>
        /// Método para verificar e validar titulos eleitorais. 
        /// </summary>
        /// <param name="titulo"></param>
        /// <returns></returns>
        public static bool vldTitulo(string titulo)
        {
            #region Cálculo do primeiro dígito verificador
            int mult = 2;
            int num = 0;
            for (int i = 0; i < 8; i++)
            {
                num += int.Parse(titulo[i].ToString()) * mult;
                mult++;
            }
            int resto = num % 11;
            int DV1 = resto == 10 ? 0 :resto;
            #endregion


            #region Cálculo do segundo dígito verificador
            int indice = 8;
            mult = 7;
            num = 0;
            for (int i = 0; i < 3; i++)
            {
                num += int.Parse(titulo[indice].ToString()) * mult;
                indice++;
                mult++;
            }
            resto = num % 11;
            int DV2 = resto == 10 ? 0 : resto;
            #endregion

            return DV1.ToString() == titulo[10].ToString() && DV2.ToString() == titulo[11].ToString();
        }

    }


}
