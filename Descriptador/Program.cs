using System;

namespace Descriptador
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tres passadas em todo o texto
            // P Qualquer caractere a partir da metade, deslocados uma posição para a direita 'a' vira 'b')
            // S linha deve ser invertida (aditrevni)
            // T Qualquer caractere devem ser deslocado  3 posicao para esquerda (d deve virar a)

            string texto = Console.ReadLine().ToString();

            //Deslocando um de qualquer caractere a partir da metade metade em diante. 
            string P = string.Empty;
            char[] indoUm = new char[texto.Length];
            int truncado = texto.Length / 2;
            for (int i = 0; i < texto.Length; i++)
            {

                indoUm[i] = texto[i];

                if (i >= truncado)
                {
                    int x = (int)indoUm[i];
                    x += 1;
                    indoUm[i] = (char)x;
                }

                 P += ((char)indoUm[i]).ToString();

            }

            //Invertendo o texto
            string textoInvertido = string.Empty;
            char[] invertendo = new char[texto.Length];
            int j = 0;
            for (int i = (texto.Length - 1); i >= 0; i--)
            {
                invertendo[j] = P[i];
                textoInvertido += ((char)invertendo[j]).ToString();
                j++;
            }

            //Deslocando tres de qualquer caractere para esquerda.
            string T = string.Empty;
            char[] voltandoTres = new char[texto.Length];
            for(int i = 0; i < texto.Length; i++)
            {
                int x = (int)textoInvertido[i] - 3;
                voltandoTres[i] = (char)x;

                T += ((char)voltandoTres[i]).ToString();                             

            }

            Console.WriteLine(T);


        }
    }
}
