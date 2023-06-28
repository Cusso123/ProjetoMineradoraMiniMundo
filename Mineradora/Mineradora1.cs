using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaMineradora
{
    public class Mineradora1 : MineradoraBase
    {
        public override void IniciarExploracao()
        {
            Exploracao exploracao = new Exploracao();
            exploracao.IdentificacaoDeAreasPromissoras();
            Random random = new Random();
            int Id1 = random.Next(0,999999);
            exploracao.Id = Id1;
            Exploracoes.Add(exploracao);

        }
    }
}
