using System;
using System.Collections.Generic;

namespace ExerciceLotoArtens
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numerosLoto = CreationGrilleLoto(1, 49);

            int[] loto = CreationLoto(7, numerosLoto);

            AffichageNumeroLoto(loto);
        }

        static List<int> CreationGrilleLoto(int numMinLoto, int numMaxLoto)
        {
            List<int> grilleLoto = new List<int>();

            for (int i = numMinLoto; i <= numMaxLoto; i++)
            {
                grilleLoto.Add(i);
            }

            return grilleLoto;
        }

        static int[] CreationLoto(int nombreBouleLoto, List<int> numerosLoto)
        {
            int[] loto = new int[nombreBouleLoto];

            for (int i = 0; i < loto.Length; i++)
            {
                Random randNum = new Random();
                int numeroAleatoire = numerosLoto[randNum.Next(numerosLoto.Count)];

                loto[i] = numeroAleatoire;
                numerosLoto.Remove(numeroAleatoire);
            }

            return loto;
        }

        static void AffichageNumeroLoto(int[] loto)
        {
            Console.WriteLine("Tirage du Loto");
            foreach (int numeroLoto in loto)
            {
                Console.WriteLine("Numero : " + numeroLoto);
            }
        }
    }
}
