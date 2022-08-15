using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProtocoloAPI.Data.Repositorio.Interface
{
    public interface IIGenericRepositorio<T> where T : class
    {
        void Adicionar(T entidade);

        List<T> ObterTodos();

        List<T> Obter(Expression<Func<T, bool>> predicate);

        T Buscar(params object[] Key);

        T Primeiro(Expression<Func<T, bool>> predicate);

        void Atualizar(T entidade);

        void Deletar(int i);

        void Commit();
    }
}
