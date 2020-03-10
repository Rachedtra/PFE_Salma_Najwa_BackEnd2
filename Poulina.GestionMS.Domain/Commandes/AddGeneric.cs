using MediatR;
using Poulina.GestionMS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poulina.GestionMS.Domain.Commandes
{
    public class AddGeneric<T> : IRequest<string> where T : class
    {
        public AddGeneric(T obj)
        {

            Obj = obj;
        }
        public T Obj { get; }
    }
}
