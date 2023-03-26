using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio04
{
    public class Ejercicio03
    {
        public string Sumar(string num1, string num2) 
        {
            int i = num1.Length - 1;
            int j = num2.Length - 1;

            int residuo = 0;
            string resultado = "";

            while(i >=0 && j >= 0)
            {
                int suma = residuo + (num1[i] - '0') + (num2[j] - '0');

                resultado = (suma % 10) + resultado;

                residuo = suma / 10;
                i--;
                j--;
            }

            while (i >= 0)
            {
                int suma = residuo + (num1[i] - '0');
                resultado = (suma % 10) + resultado;
                residuo = suma / 10;
                i--;
            }

            while (j >= 0)
            {
                int suma = residuo + (num2[j] - '0');
                resultado = (suma % 10) + resultado;
                residuo = suma / 10;
                j--;
            }

            if(residuo > 0)
            {
                resultado = residuo + resultado;
            }

            return resultado;
        }
    }
}
