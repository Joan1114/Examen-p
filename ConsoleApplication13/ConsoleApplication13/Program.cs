using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            int voto1 = 0;
            int voto2 = 0;
            int voto3 = 0;
            int voto4 = 0;

            int rnd; 
            string [] candidatos = { "Lui Jabinadel", "Danilo Mejia", "El lidel", "El Penco" };
            string[] partidos = { "Partido de la Liberacion Dominicana (PLD)", "Partido Revolucionario Moderno (PRM)", "Pueblo la Fuerza (PF)", "La Fuerza del Penco (LFP)" };
            int[] funda = { 1983, 1954, 2014, 2020 };

            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("\nPartido: " + partidos[i]);
                Console.WriteLine("Año de fundación: " + funda[i]);
                Console.WriteLine("Candidato: " + candidatos[i]);
                Console.WriteLine("Aspira a: Presidente");
            }

            for (int i = 0; i < 1000; i++)
            {
                Random aleatorio = new Random();
                rnd = aleatorio.Next(1, 5);

                if (rnd == 1)
                {
                    voto1++;
                }
                if (rnd == 2)
                {
                    voto2++;
                }
                if (rnd == 3)
                {
                    voto3++;
                }
                if (rnd == 4)
                {
                    voto4++;
                }
            }

            double result = voto1 + voto2 + voto3 + voto4;

            double candidato1 = (voto1 / result) * 100;
            double candidato2 = (voto2 / result) * 100;
            double candidato3 = (voto3 / result) * 100;
            double candidato4 = (voto4 / result) * 100;

            Console.WriteLine(candidatos[0] + " obtuvo " + voto1 + " votos y un porcetaje de " + candidato1 + "%");
            Console.WriteLine(candidatos[1] + " obtuvo " + voto2 + " votos y un porcetaje de " + candidato2 + "%");
            Console.WriteLine(candidatos[2] + " obtuvo " + voto3 + " votos y un porcetaje de " + candidato3 + "%"); 
            Console.WriteLine(candidatos[3] + " obtuvo " + voto4 + " votos y un porcetaje de " + candidato4 + "%");

            if (voto1 > voto2 && voto1 > voto3 && voto1 > voto4)
            {
                Console.WriteLine("El ganador de las elecciones es: " + candidatos[0]);
            } if (voto2 > voto1 && voto2 > voto3 && voto2 > voto4)
            {
                Console.WriteLine("El ganador de las elecciones es: " + candidatos[1]);
            } if (voto3 > voto1 && voto3 > voto2 && voto3 > voto4)
            {
                Console.WriteLine("El ganador de las elecciones es: " + candidatos[2]);
            } if (voto4 > voto1 && voto4 > voto2 && voto4 > voto3)
            {
                Console.WriteLine("El ganador de las elecciones es: " + candidatos[3]);
            }

            Console.ReadKey();

        }
    }
}
