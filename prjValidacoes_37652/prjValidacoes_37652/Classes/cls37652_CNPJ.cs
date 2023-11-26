using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj37652_CNPJ
{
    internal class cls37652_CNPJ
    {
        /// <summary>
        /// Esse método recebe os valores do CNPJ em string e retorna bool validando o mesmo
        /// </summary>
        /// <param name="cnpj"></param>
        /// <returns></returns>
        public  static bool CNPJ(string cnpj)
        {
            int verificador =0;
            int num = 0;
            int[] multiDigito1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiDigito2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            #region Verificar primeiro digito verificador
            for (int i = 0; i < 12; i++)
            {
                num += int.Parse(cnpj.Substring(i, 1)) * multiDigito1[i];
            }
            verificador = num % 11;
            verificador = verificador < 2 ? 0 : 11 - verificador;

            if(cnpj[12].ToString() != verificador.ToString())
            {
                return false;
            }
            #endregion


            #region verificar segundo digito verificador
            verificador = 0;
            num = 0;

            for (int i = 0; i < 13; i++)
            {
                num += int.Parse(cnpj.Substring(i, 1)) * multiDigito2[i];
            }
            verificador = num % 11;
            verificador = verificador < 2 ? 0 : 11 - verificador;

            if (cnpj[13].ToString() != verificador.ToString())
            {
                return false;
            }
            #endregion


            return true;

        }
    }
}
