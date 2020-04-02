using MediatR;
using Poulina.GestionMS.Domain.Commandes;
using Poulina.GestionMS.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Poulina.GestionMS.Domain.Handlers
{
    public class DeleteHandler<T> : IRequestHandler<DeleteGeniric<T>, string> where T : class
    {
        private readonly IRepository<T> repository;
        public DeleteHandler(IRepository<T> Repository)
        {
            repository = Repository;
        }
           public Task<string> Handle(DeleteGeniric<T> request, CancellationToken cancellationToken)
        {

            var result = repository.Delete(request.Id);
            return Task.FromResult(result);
        }
    }
}