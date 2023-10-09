
//####MARIA CLARA REZENDE VIANNA 3° CICLO MANHÃ JD####//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atvd_POO_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jogador jogador1 = new Jogador("Jogador1");
            Console.Write("Infome o nome do player 1: ");
            jogador1.Nome = Console.ReadLine();
            jogador1.Pontuacao = 0;


            Jogador jogador2 = new Jogador("Jogador2");
            Console.Write("Infome o nome do player 2: ");
            jogador2.Nome = Console.ReadLine();
            jogador2.Pontuacao = 0;

            // Aumente a pontuação dos jogadores
            jogador1.AumentarPontuacao(-10);
            jogador2.AumentarPontuacao(5);

            jogador1.Apresentar();
            jogador2.Apresentar();




            Console.ReadKey();

        }

        class Jogador
        {
            private string nome;

            public string Nome
            {
                get
                {
                    return nome;
                }
                set
                {
                    nome = value;
                }

            }

            private int pontuacao; //Atributo PRIVADO

            public int Pontuacao //Metodo de Acesso PUBLICO
            {
                get // "Pegar" retornar para fora do objeto
                {
                    return pontuacao;
                }

                set  // "Atribuir" receber um valor externo
                {
                    pontuacao = value;
                }
            }

            public Jogador(string nome) 
            {
                this.nome = nome;
                pontuacao = 0;
            }

            public void Apresentar()
            {
                Console.WriteLine("Nome do Personagem: " + this.nome);
                Console.WriteLine("Pontuação do Personagem: " + this.pontuacao);
            }

            public void AumentarPontuacao(int ValorRecebido)
            {
                if (ValorRecebido > 0)
                {
                    pontuacao += ValorRecebido;
                }

                else { Console.WriteLine("Digite um valor positivo"); }

            }

            
        }
    }
}
