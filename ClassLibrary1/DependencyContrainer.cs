using MediatR;
using Microsoft.Extensions.DependencyInjection;

using System.Collections.Generic;
using System.Text;

using Poulina.GestionMs.Data.Context;
using Poulina.GestionMs.Data.Repository;
using Poulina.GestionMS.Domain.Commandes;
using Poulina.GestionMS.Domain.Handlers;
using Poulina.GestionMS.Domain.Interfaces;
using Poulina.GestionMS.Domain.Models;
using Poulina.GestionMS.Domain.Queries;
using System.Reflection;

namespace GestionMS.Infr.Ioc
{
    public class DependencyContrainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<GestionMSContext>();


            services.AddScoped<IRepository<MS>, Repository<MS>>();
            services.AddScoped<IRequestHandler<AddGeneric<MS>, string>, AddHandler<MS>>();
            services.AddScoped<IRequestHandler<DeleteGeniric<MS>, string>, DeleteHandler<MS>>();
            services.AddScoped<IRequestHandler<PutGeneric<MS>, string>, PutHandler<MS>>();
            services.AddScoped<IRequestHandler<GetAllQuery<MS>, IEnumerable<MS>>, GetAllHandler<MS>>();
            services.AddScoped<IRequestHandler<GetQueryByID<MS>, MS>, GetByIdHandler<MS>>();


            services.AddScoped<IRepository<Domaine>, Repository<Domaine>>();
            services.AddScoped<IRequestHandler<AddGeneric<Domaine>, string>, AddHandler<Domaine>>();
            services.AddScoped<IRequestHandler<DeleteGeniric<Domaine>, string>, DeleteHandler<Domaine>>();
            services.AddScoped<IRequestHandler<PutGeneric<Domaine>, string>, PutHandler<Domaine>>();
            services.AddScoped<IRequestHandler<GetAllQuery<Domaine>, IEnumerable<Domaine>>, GetAllHandler<Domaine>>();
            services.AddScoped<IRequestHandler<GetQueryByID<Domaine>, Domaine>, GetByIdHandler<Domaine>>();

            services.AddScoped<IRepository<Language>, Repository<Language>>();
            services.AddScoped<IRequestHandler<AddGeneric<Language>, string>, AddHandler<Language>>();
            services.AddScoped<IRequestHandler<DeleteGeniric<Language>, string>, DeleteHandler<Language>>();
            services.AddScoped<IRequestHandler<PutGeneric<Language>, string>, PutHandler<Language>>();
            services.AddScoped<IRequestHandler<GetAllQuery<Language>, IEnumerable<Language>>, GetAllHandler<Language>>();
            services.AddScoped<IRequestHandler<GetQueryByID<Language>, Language>, GetByIdHandler<Language>>();

            services.AddScoped<IRepository<Methode>, Repository<Methode>>();
            services.AddScoped<IRequestHandler<AddGeneric<Methode>, string>, AddHandler<Methode>>();
            services.AddScoped<IRequestHandler<DeleteGeniric<Methode>, string>, DeleteHandler<Methode>>();
            services.AddScoped<IRequestHandler<PutGeneric<Methode>, string>, PutHandler<Methode>>();
            services.AddScoped<IRequestHandler<GetAllQuery<Methode>, IEnumerable<Methode>>, GetAllHandler<Methode>>();
            services.AddScoped<IRequestHandler<GetQueryByID<Methode>, Methode>, GetByIdHandler<Methode>>();

            services.AddScoped<IRepository<Versions>, Repository<Versions>>();
            services.AddScoped<IRequestHandler<AddGeneric<Versions>, string>, AddHandler<Versions>>();
            services.AddScoped<IRequestHandler<DeleteGeniric<Versions>, string>, DeleteHandler<Versions>>();
            services.AddScoped<IRequestHandler<PutGeneric<Versions>, string>, PutHandler<Versions>>();
            services.AddScoped<IRequestHandler<GetAllQuery<Versions>, IEnumerable<Versions>>, GetAllHandler<Versions>>();
            services.AddScoped<IRequestHandler<GetQueryByID<Versions>, Versions>, GetByIdHandler<Versions>>();


         

        }
    }

    
}