using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaMineradora
{
    public class EngenhariaDeMinas
    {
        public void AvaliacaoDeViabilidade(Exploracao exploracao)
        {
            Random random = new Random();
            int resultado = random.Next(101); // Valor de 0 a 100

            if (resultado > 75)
            {
                Console.WriteLine("As análises são ótimas.");
                ImplementacaoDeLavras();
            }
            else if (resultado > 50)
            {
                Console.WriteLine("As análises são boas.");
                ImplementacaoDeLavras();
            }
            else if (resultado > 25)
            {
                Console.WriteLine("As análises são ruins.");
                Console.Write("Deseja tentar outra área? (S/N): ");
                string resposta = Console.ReadLine().ToUpper();

                if (resposta == "S")
                {
                    Mineradora1 mineradora = new Mineradora1();
                    mineradora.IniciarExploracao();
                }
                else
                {
                    Console.WriteLine("Exploração encerrada.");
                }
            }
            else
            {
                Console.WriteLine("As análises são péssimas.");
                Console.Write("Deseja tentar outra área? (S/N): ");
                string resposta = Console.ReadLine().ToUpper();

                if (resposta == "S")
                {
                    Mineradora1 mineradora = new Mineradora1();
                    mineradora.IniciarExploracao();
                }
                else
                {
                    Console.WriteLine("Exploração encerrada.");
                }
            }
        }

        public void ImplementacaoDeLavras()
        {
            Console.Write("A extração foi bem sucedida? (S/N): ");
            string resposta = Console.ReadLine().ToUpper();

            if (resposta == "S")
            {
                ControleEMonitoramento();
            }
            else
            {
                Console.Write("Deseja tentar outra extração? (S/N): ");
                string tentarNovamente = Console.ReadLine().ToUpper();

                if (tentarNovamente == "S")
                {
                    ImplementacaoDeLavras();
                }
                else
                {
                    Console.WriteLine("Exploração encerrada.");
                }
            }
        }

        public void ControleEMonitoramento()
        {
            Console.Write("Deseja enviar o minério para outro setor? (S/N): ");
            string resposta = Console.ReadLine().ToUpper();

            if (resposta == "S")
            {
                OperacoesDeMineracao operacoesDeMineracao = new OperacoesDeMineracao();
                operacoesDeMineracao.PerfuracaoEDesmonteDeRochas();
            }
            else
            {
                Console.WriteLine("Exploração encerrada.");
            }
        }
    }
}
