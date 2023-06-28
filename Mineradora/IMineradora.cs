using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaMineradora
{
    public interface IMineradora
    {
        void IniciarExploracao();
        void ListarExploracoes();
        void DeletarExploracao();
        void ExibirExploracao();
    }
}
