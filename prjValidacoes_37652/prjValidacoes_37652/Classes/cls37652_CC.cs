using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj37652_CC
{
    internal class cls37652_CC
    {
        public static bool validar(string CC)
        {
            int soma = 0;
            int multiplica = 0;

            #region calculo verificação
            for (int i = 0; i < CC.Length; i++)
            {
                if (i % 2 == 0)
                {
                    multiplica = int.Parse(CC[i].ToString()) * 2;
                }
                else if (i % 2 != 0)
                {
                    multiplica = int.Parse(CC[i].ToString()) * 1;
                }
                if (multiplica > 9)
                {
                    multiplica -= 9;
                }
                soma += multiplica;

            }
            #endregion

            if (soma % 10 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
