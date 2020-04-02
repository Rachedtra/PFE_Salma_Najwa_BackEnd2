using MediatR;
using Poulina.GestionMS.Domain.Interfaces;
using Poulina.GestionMS.Domain.Queries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Poulina.GestionMS.Domain.Handlers
{
   public class GetAllHandler<T> : IRequestHandler<GetAllQuery<T>, IEnumerable<T>> where T : class
    {
        private readonly IRepository<T> repository;
        public GetAllHandler(IRepository<T> Repository)
        {
            repository = Repository;
        }

        public Task<IEnumerable<T>> Handle(GetAllQuery<T> request, CancellationToken cancellationToken)
        {
            var x = repository.GetAll();
            return Task.FromResult(x);
        }
    }
}