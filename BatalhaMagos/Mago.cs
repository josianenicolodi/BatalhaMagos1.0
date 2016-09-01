using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatalhaMagos
{
    class Mago
    {
        public string nome, escola;
        private int vida, mana, forca, agilidade, defesa;

        public bool Alive
        {
            get
            {
                return vida > 0;
            }
        }


        public Mago(string defineNome, string defineEscola, int defineVida, int defineMana,
            int defineForca, int defineAgilidade, int defineDefesa)
        {
            nome = defineNome;
            escola = defineEscola;
            vida = defineVida;
            mana = defineMana;
            forca = defineForca;
            agilidade = defineAgilidade;
            defesa = defineDefesa;

        }

        public override string ToString()
        {
            return this.nome + " da escola " + this.escola; 
        }

        internal void Defender(Mago personagem1)
        {
            Defender(personagem1.forca);
        }

        public void SofreDano(int qt)
        {
            this.vida -= qt;
            Console.WriteLine(this.nome + " Sofreu " + qt + " de dano.");
        }

        public void Defender(int qt)
        {
            int dFinal = qt - defesa;

            if (dFinal > 0)
            {
                this.vida -= dFinal;
                Console.WriteLine(this.nome + " sofreu dano de " + dFinal);

            }
            else
            {
                Console.WriteLine(this.nome + " não sofreu dano!");
            }
        }

        internal void Atacar(Mago personagem2)
        {
            personagem2.SofreDano(this.forca);
            Console.WriteLine(this.nome + " atacou " + personagem2.nome);
        }
    }
}
