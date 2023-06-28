using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaMineradora
{
    public class OperacoesDeMineracao
    {
        public void PerfuracaoEDesmonteDeRochas()
        {
            string[] tiposMinerios = { "Ouro", "Prata", "Cobre", "Ferro", "Alumínio" };
            Random random = new Random();
            string tipoMinerio = tiposMinerios[random.Next(tiposMinerios.Length)];

            ControleDeQualidade(tipoMinerio);
        }
        public void ControleDeQualidade(string tipoMinerio)
        {
            Random random = new Random();
            int qualidade = random.Next(101); // Valor de 0 a 100

            if (qualidade > 25)
            {
                Console.WriteLine($"O minério de {tipoMinerio} é bom.");
                BeneficiamentoMineral(tipoMinerio);
            }
            else
            {
                Console.WriteLine($"O minério de {tipoMinerio} é ruim.");
                Console.WriteLine("Exploração encerrada.");
            }
        }

        public void BeneficiamentoMineral(string tipoMinerio)
        {
            if (tipoMinerio == "Ouro" || tipoMinerio == "Prata" || tipoMinerio == "Cobre")
            {
                Console.WriteLine("Lucro superior a 100 milhões.");
            }
            else
            {
                Console.WriteLine("Lucro inferior a 100 milhões.");
            }

            CarregamentoETransporte();
        }

        public void CarregamentoETransporte()
        {
            if (ManutencaoDeEquipamentos())
            {
                Console.WriteLine("Os caminhões precisam de manutenção.");
            }
            else
            {
                Console.WriteLine("Os caminhões não precisam de manutenção.");
            }
                Console.WriteLine("Exploração encerrada.");
        }

        public bool ManutencaoDeEquipamentos()
        {
            Console.Write("Deseja enviar para outra indústria ou armazenar os minerais? ((I)Industria/(A)Armazenar): ");
            string resposta = Console.ReadLine().ToUpper();

            if (resposta == "I")
            {
                return true;
            }
            return false;
        }
    }
}
