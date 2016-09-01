using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatalhaMagos
{
    class Batalha
    {
        public Mago personagem1, personagem2;

        public void Fight()
        {
            ACAO ac = ACAO.ATACAR;

            do
            {
                ac = Choose();
                switch (ac)
                {
                    case ACAO.ATACAR:
                        personagem1.Atacar(personagem2);
                        personagem2.Atacar(personagem1);

                        break;
                    case ACAO.DEFENDER:
                        personagem1.Defender(personagem2);

                        break;

                }


            } while (personagem1.Alive && personagem2.Alive);

            Console.WriteLine(" Final da batalha!");

            if (personagem1.Alive)
            {
                Console.WriteLine(personagem1 + " Venceu!!");
            }
            else
            {
                Console.WriteLine(personagem2 + "Venceu!!");
            }
        }



        public ACAO Choose()
        {
            string resposta;

            Console.WriteLine("Escolha uma opcao:");
            Console.WriteLine("1 - Defender.");
            Console.WriteLine("2 - Atacar. ");
            resposta = Console.ReadLine();

            switch (resposta)
            {
                case "1":
                    return ACAO.ATACAR;
                case "2":
                    return ACAO.DEFENDER;
                default:
                    Console.WriteLine("Opção invalida!!");
                    return Choose();
                    break;
            }
            return ACAO.DEFENDER;
        }

    }
}


enum ACAO
{
    ATACAR,
    DEFENDER

}