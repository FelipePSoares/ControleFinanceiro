using DomainService.Contracts;
using Entities;
using Repository.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService
{
    public class TransacaoBO : ITransacaoBO
    {
        public ITransacaoRepository repository { get; set; }

        public TransacaoBO(ITransacaoRepository repository)
        {
            this.repository = repository;
        }

        public void Add(Transacao transacao)
        {
            EPossivelAdicionar(transacao);

            repository.add<Transacao>(transacao);
        }

        #region [ Validação ]

        //TODO: Implementar método
        protected void EPossivelAdicionar(Transacao transacao)
        {
        }

        #endregion
    }
}
