using DomainService.Contracts;
using Entities;
using Repository.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DomainService
{
    public class TransacaoBO : ITransacaoBO
    {
        private IGenericRepository<Transacao> repository { get; set; }

        public TransacaoBO(IGenericRepository<Transacao> repository)
        {
            this.repository = repository;
        }

        public void Add(Transacao transacao)
        {
            //EPossivelAdicionar(transacao);

            repository.add(transacao);

            repository.Commit();
        }

        public IQueryable<Transacao> Search(Expression<Func<Transacao, bool>> predicate)
        {
            return this.Search(predicate, null);
        }

        public IQueryable<Transacao> Search(Expression<Func<Transacao, bool>> predicate, String[] include)
        {
            return repository.Find(predicate, include);
        }

        #region [ Validação ]

        //TODO: Implementar método
        protected void EPossivelAdicionar(Transacao transacao)
        {
        }

        #endregion
    }
}
