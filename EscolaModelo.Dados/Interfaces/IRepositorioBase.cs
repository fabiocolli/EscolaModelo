using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaModelo.Dados.Interfaces
{
    public interface IRepositorioBase<T> where T : class
    {
        List<T> ListarTodos();
        T ListarPorId(params object[] param);
        T Incluir(T objeto);
        T Alterar(T objeto);
        bool Excluir(T objeto);
        bool ExcluirPorIs(T objeto);
        void SalvarAlteracoes();
    }
}
