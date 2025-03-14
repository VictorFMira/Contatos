using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cont.Dominio.Entidades;

namespace Cont.Dominio.Intefaces
{
    public interface IUnitOfWork
    {
        Task InserirAsync<T>(T entidade) where T : EntidadeBase;

        Task AtualizarAsync<T>(T entidade) where T : EntidadeBase;

        Task ExcluirAsync<T>(T entidade) where T : EntidadeBase;

        Task<IEnumerable<T>> ObterTodos<T>() where T : EntidadeBase;

        Task<T> ObterPorId<T>(int id) where T : EntidadeBase;

        Task<int> SalvarAlteracoesAsync(CancellationToken cancelationToken = default);
    }
}
