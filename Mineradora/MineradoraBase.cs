using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaMineradora
{
    public abstract class MineradoraBase : IMineradora
    {
        public List<Exploracao> Exploracoes { get; set; }

        public MineradoraBase()
        {
            Exploracoes = new List<Exploracao>();
        }

        public abstract void IniciarExploracao();

        public void ListarExploracoes()
        {
            foreach (var exploracao in Exploracoes)
            {
                Console.WriteLine($"Exploração ID: {exploracao.Id}");
            }
        }

        public void DeletarExploracao()
        {
            Console.Write("Informe o ID da exploração que deseja deletar: ");
            int id = int.Parse(Console.ReadLine());

            Exploracao exploracao = Exploracoes.Find(e => e.Id == id);
            if (exploracao != null)
            {
                Exploracoes.Remove(exploracao);
                Console.WriteLine($"Exploração ID: {id} deletada com sucesso.");
            }
            else
            {
                Console.WriteLine("Exploração não encontrada.");
            }
        }
        public void ExibirExploracao()
        {
            foreach (var exploracao in Exploracoes)
            {
                Console.WriteLine($"Exploração ID: {exploracao.Id}");
                Console.WriteLine($"Area Promissora: {exploracao.AreaPromissora}");
                Console.WriteLine($"Sucesso perfuração: {exploracao.PerfuracaoSucesso}");
                Console.WriteLine($"A mostra enviada: {exploracao.AmostraEnviada}");
                Console.WriteLine($"Quantidade enviada: {exploracao.QtdRochasEnviadas}");
                Console.WriteLine();
            }
        }
    }
}
