using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace RGvalidacao
{
    internal class CLS_RG
    {
        /// <summary>
        /// Esse método receb a string do RG e retorna booleano se o mesmo é válido ou não
        /// </summary>
        /// <param name="rg"></param>
        /// <returns></returns>
        public static bool RG(string rg)
        {
            int count = 9;
            int num = 0;
            for (int i = 0; i < 8; i++)
            {
                num += int.Parse(rg.Substring(i, 1)) * count;
                count--;
            }
            int resto = num % 11;

            if (((rg[8] == 'x') || (rg[8] == 'X')) && (resto == 10))
            {
                return true;
            }
            string verificador = rg[8].ToString();
            return verificador != resto.ToString() ? false : true;



        }
    }
}
