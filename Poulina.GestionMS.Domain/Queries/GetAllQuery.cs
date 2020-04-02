using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Poulina.GestionMS.Domain.Commandes;
using Poulina.GestionMS.Domain.Interfaces;
using Poulina.GestionMS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Poulina.GestionMS.Domain.Queries
{
    public class GetAllQuery<T> : IRequest<IEnumerable<T>> where T : class
    {
    }
}

