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
    public class AddHandler<T> : IRequestHandler<AddGeneric<T>, string> where T : class
    {
        private readonly IRepository<T> repository;
        public AddHandler(IRepository<T> Repository)
        {
            repository = Repository;
        }
        public Task<string> Handle(AddGeneric<T> request, CancellationToken cancellationToken)
        {
            var result = repository.Add(request.Obj);
            return Task.FromResult(result);
        }
    }
}