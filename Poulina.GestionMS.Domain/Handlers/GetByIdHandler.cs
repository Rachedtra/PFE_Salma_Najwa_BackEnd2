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

    public class GetByIdHandler<T> : IRequestHandler<GetQueryByID<T>,T> where T : class
    {
        private readonly IRepository<T> repository;
        public GetByIdHandler(IRepository<T> Repository)
        {
            repository = Repository;
        }
  

        public Task<T> Handle(GetQueryByID<T> request, CancellationToken cancellationToken)
        {
            var result = repository.GetById(request.Id);
            return Task.FromResult(result);
        }
    }
}