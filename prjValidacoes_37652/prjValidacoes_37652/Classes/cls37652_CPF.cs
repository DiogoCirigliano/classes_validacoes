using System;

namespace prj37652_CPF
{
    internal class cls37652_CPF
    {
        public static bool vldDigito(string cpf)
        {
            int restodigito = 0;
            int soma = 0;
            int multiplica = 11;
            int digito1 = 0;
            int digito2 = 0;

            // Validação do primeiro dígito verificador
            for (int m = 0; m < 9; m++)
            {
                multiplica = multiplica - 1;
                soma += int.Parse(cpf[m].ToString()) * multiplica;
            }
            restodigito = soma % 11;

            if (restodigito > 1)
            {
                digito1 = 11 - restodigito;
            }
            else
            {
                digito1 = 0;
            }

            // Validação do segundo dígito verificador
            multiplica = 12; 
            soma = 0; 

            for (int m = 0; m < 10; m++)
            {
                multiplica = multiplica - 1;
                soma += int.Parse(cpf[m].ToString()) * multiplica;
            }
            restodigito = soma % 11;

            if (restodigito > 1)
            {
                digito2 = 11 - restodigito;
            }
            else
            {
                digito2 = 0;
            }

            // Verificação dos dígitos verificadores
            if (digito1 == int.Parse(cpf[9].ToString()) && digito2 == int.Parse(cpf[10].ToString()))
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
