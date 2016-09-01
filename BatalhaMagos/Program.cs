using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatalhaMagos
{
    class Program
    {

        static public Random rd = new Random();

        static void Main(string[] args)
        {
            Mago[] vetorMagos = new Mago[10];

            string[] nomes = new string[10] { "Lola", "Athena", "Hanna",
                "Tete", "Cafune", "Luna", "Yoshi", "Bolinha", "Maui", "Brisa" };
            string[] escolas = new string[3] { "Cachorrodromo Parcao",
                "Cachorrodromo dos Açorianos", "Cachorrodromo Encol" };

            for (int i = 0; i < vetorMagos.Length; i++)
            {
                vetorMagos[i] = new Mago(nomes[i], escolas[rd.Next(0, escolas.Length)],
                    rd.Next(10, 50), rd.Next(10, 50), rd.Next(10, 50), rd.Next(10, 50),
                    rd.Next(10, 50));
            }
            Batalha battle = new Batalha();

            Console.WriteLine(" Escolha o mago");
            battle.personagem1 = chooseMago(vetorMagos);

            battle.personagem2 = vetorMagos[4];

            battle.Fight();

            Console.WriteLine(vetorMagos);
            Console.WriteLine(vetorMagos.ToString());

            Console.ReadLine();
        }

        static Mago chooseMago(Mago[] vetor)
        {
            int posicao;

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(i + 1 + " - " + vetor[i].nome + " da escola " + vetor[i].escola);

            }
            posicao = Convert.ToInt32(Console.ReadLine());
            if (posicao > 0 && posicao < vetor.Length +1)
            {
                return vetor[posicao-1];
            }

            Console.WriteLine("Mago invalido!");
            chooseMago(vetor);


            return null;


        }

    }
}
