using System;
using System.Collections.Generic;
using System.Text;

namespace GestionMS.Infr.Ioc
{
    class Class1
    {
    }
}


//////////////////////////////
///
//using MediatR;
//using Microsoft.Extensions.DependencyInjection;

//using System.Collections.Generic;
//using System.Text;

//using Poulina.ActionPlan.Data.Context;
//using Poulina.ActionPlan.Data.Repository;
//using Poulina.ActionPlan.Domain.Commandes;
//using Poulina.ActionPlan.Domain.Handlers;
//using Poulina.ActionPlan.Domain.Interfaces;
//using Poulina.ActionPlan.Domain.Models;
//using Poulina.ActionPlan.Domain.Queries;


//namespace ActionPlan.Infra.Ioc
//{
//    public class DependencyContrainer
//    {
//        public static void RegisterServices(IServiceCollection services)
//        {
//            services.AddTransient<ActionPlanContext>();

//            services.AddTransient<IRepository<Action>, Repository<Action>>();
//            services.AddTransient<IRequestHandler<AddGeneric<Action>, string>, AddGenericHandler<Action>>();
//            services.AddTransient<IRequestHandler<PutGeneric<Action>, string>, PutGenericHandler<Action>>();
//            services.AddTransient<IRequestHandler<DeleteGeneric<Action>, string>, DeleteGenericHandler<Action>>();
//            services.AddTransient<IRequestHandler<GetAllGenericQuery<Action>, IEnumerable<Action>>, GetAllGenericHandler<Action>>();
//            services.AddTransient<IRequestHandler<GetGenericQueryByID<Action>, Action>, GetByIDGenericHandler<Action>>();


//            services.AddTransient<IRepository<Project>, Repository<Project>>();
//            services.AddTransient<IRequestHandler<AddGeneric<Project>, string>, AddGenericHandler<Project>>();
//            services.AddTransient<IRequestHandler<PutGeneric<Project>, string>, PutGenericHandler<Project>>();
//            services.AddTransient<IRequestHandler<DeleteGeneric<Project>, string>, DeleteGenericHandler<Project>>();
//            services.AddTransient<IRequestHandler<GetAllGenericQuery<Project>, IEnumerable<Project>>, GetAllGenericHandler<Project>>();
//            services.AddTransient<IRequestHandler<GetGenericQueryByID<Project>, Project>, GetByIDGenericHandler<Project>>();


//            services.AddTransient<IRepository<Goal>, Repository<Goal>>();
//            services.AddTransient<IRequestHandler<AddGeneric<Goal>, string>, AddGenericHandler<Goal>>();
//            services.AddTransient<IRequestHandler<PutGeneric<Goal>, string>, PutGenericHandler<Goal>>();
//            services.AddTransient<IRequestHandler<DeleteGeneric<Goal>, string>, DeleteGenericHandler<Goal>>();
//            services.AddTransient<IRequestHandler<GetAllGenericQuery<Goal>, IEnumerable<Goal>>, GetAllGenericHandler<Goal>>();
//            services.AddTransient<IRequestHandler<GetGenericQueryByID<Goal>, Goal>, GetByIDGenericHandler<Goal>>();


//            services.AddTransient<IRepository<Repetition>, Repository<Repetition>>();
//            services.AddTransient<IRequestHandler<AddGeneric<Repetition>, string>, AddGenericHandler<Repetition>>();
//            services.AddTransient<IRequestHandler<PutGeneric<Repetition>, string>, PutGenericHandler<Repetition>>();
//            services.AddTransient<IRequestHandler<DeleteGeneric<Repetition>, string>, DeleteGenericHandler<Repetition>>();
//            services.AddTransient<IRequestHandler<GetAllGenericQuery<Repetition>, IEnumerable<Repetition>>, GetAllGenericHandler<Repetition>>();
//            services.AddTransient<IRequestHandler<GetGenericQueryByID<Repetition>, Repetition>, GetByIDGenericHandler<Repetition>>();

//            services.AddTransient<IRepository<Reminder>, Repository<Reminder>>();
//            services.AddTransient<IRequestHandler<AddGeneric<Reminder>, string>, AddGenericHandler<Reminder>>();
//            services.AddTransient<IRequestHandler<PutGeneric<Reminder>, string>, PutGenericHandler<Reminder>>();
//            services.AddTransient<IRequestHandler<DeleteGeneric<Reminder>, string>, DeleteGenericHandler<Reminder>>();
//            services.AddTransient<IRequestHandler<GetAllGenericQuery<Reminder>, IEnumerable<Reminder>>, GetAllGenericHandler<Reminder>>();
//            services.AddTransient<IRequestHandler<GetGenericQueryByID<Reminder>, Reminder>, GetByIDGenericHandler<Reminder>>();

//            services.AddTransient<IRepository<Priority>, Repository<Priority>>();
//            services.AddTransient<IRequestHandler<AddGeneric<Priority>, string>, AddGenericHandler<Priority>>();
//            services.AddTransient<IRequestHandler<PutGeneric<Priority>, string>, PutGenericHandler<Priority>>();
//            services.AddTransient<IRequestHandler<DeleteGeneric<Priority>, string>, DeleteGenericHandler<Priority>>();
//            services.AddTransient<IRequestHandler<GetAllGenericQuery<Priority>, IEnumerable<Priority>>, GetAllGenericHandler<Priority>>();
//            services.AddTransient<IRequestHandler<GetGenericQueryByID<Priority>, Priority>, GetByIDGenericHandler<Priority>>();

//            services.AddTransient<IRepository<ProgressStatus>, Repository<ProgressStatus>>();
//            services.AddTransient<IRequestHandler<AddGeneric<ProgressStatus>, string>, AddGenericHandler<ProgressStatus>>();
//            services.AddTransient<IRequestHandler<PutGeneric<ProgressStatus>, string>, PutGenericHandler<ProgressStatus>>();
//            services.AddTransient<IRequestHandler<DeleteGeneric<ProgressStatus>, string>, DeleteGenericHandler<ProgressStatus>>();
//            services.AddTransient<IRequestHandler<GetAllGenericQuery<ProgressStatus>, IEnumerable<ProgressStatus>>, GetAllGenericHandler<ProgressStatus>>();
//            services.AddTransient<IRequestHandler<GetGenericQueryByID<ProgressStatus>, ProgressStatus>, GetByIDGenericHandler<ProgressStatus>>();

//            services.AddTransient<IRepository<Attachment>, Repository<Attachment>>();
//            services.AddTransient<IRequestHandler<AddGeneric<Attachment>, string>, AddGenericHandler<Attachment>>();
//            services.AddTransient<IRequestHandler<PutGeneric<Attachment>, string>, PutGenericHandler<Attachment>>();
//            services.AddTransient<IRequestHandler<DeleteGeneric<Attachment>, string>, DeleteGenericHandler<Attachment>>();
//            services.AddTransient<IRequestHandler<GetAllGenericQuery<Attachment>, IEnumerable<Attachment>>, GetAllGenericHandler<Attachment>>();
//            services.AddTransient<IRequestHandler<GetGenericQueryByID<Attachment>, Attachment>, GetByIDGenericHandler<Attachment>>();

//        }
//    }
//}