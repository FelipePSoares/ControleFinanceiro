using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Contracts
{
    public interface ITransacaoBO
    {
        void Add(Transacao transacao);

        IQueryable<Transacao> Search(Expression<Func<Transacao, bool>> predicate);

        IQueryable<Transacao> Search(Expression<Func<Transacao, bool>> predicate, String[] include);
    }
}
