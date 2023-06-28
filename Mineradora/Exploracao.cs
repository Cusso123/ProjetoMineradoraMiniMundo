using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaMineradora
{
    public class Exploracao
    {
        public int Id { get; set; }
        public bool AreaPromissora { get; set; }
        public bool PerfuracaoSucesso { get; set; }
        public bool AmostraEnviada { get; set; }
        public int QtdRochasEnviadas { get; set; }

        public void IdentificacaoDeAreasPromissoras()
        {
            Console.Write("Que área voce deseja extrair? (Responda com A, B, C, D, E): ");
            string resposta = Console.ReadLine().ToUpper();

            if (resposta == "A" || resposta == "C" || resposta == "E")
            {
                AreaPromissora = true;
            }
            else if (resposta == "B" || resposta == "D")
            {
                AreaPromissora = false;
                Console.WriteLine("A mineradora não possui tecnologia suficiente para perfurar nessa área.");
                return;
            }

            PerfurarPocos();
        }

        public void PerfurarPocos()
        {
            Console.Write("Em que posição você quer perfurar? (1-Nord, 2-Est, 3-Ovest, 4-Sul): ");
            int posicao = int.Parse(Console.ReadLine());

            Random random = new Random();
            PerfuracaoSucesso = random.Next(2) == 0; // 50% de chance de sucesso

            if (PerfuracaoSucesso)
            {
                AmostragemEAnalise();
            }
            else
            {
                Console.Write("O buraco não possui condições para perfuração.");
                Console.Write("Deseja tentar em outra posição? (S/N): ");
                string resposta = Console.ReadLine().ToUpper();

                if (resposta == "S")
                {
                    PerfurarPocos();
                }
                else
                {
                    Console.WriteLine("Exploração encerrada.");
                }
            }
        }

        public void AmostragemEAnalise()
        {
            Console.Write("Deseja enviar amostra para análise? (S/N): ");
            string resposta = Console.ReadLine().ToUpper();

            if (resposta == "S")
            {
                AmostraEnviada = true;

                Console.Write("Quantas rochas deseja enviar para análise?: ");
                QtdRochasEnviadas = int.Parse(Console.ReadLine());

                if (QtdRochasEnviadas < 10000)
                {
                    EngenhariaDeMinas engenhariaDeMinas = new EngenhariaDeMinas();
                    engenhariaDeMinas.AvaliacaoDeViabilidade(this);
                }
                else
                {
                    Console.WriteLine("A quantidade de rochas excede o limite máximo para análise.");
                    Console.WriteLine("A mineradora não possui tecnologia suficiente.");
                }
            }
            else
            {
                Console.WriteLine("Exploração encerrada.");
            }
        }
    }
}
