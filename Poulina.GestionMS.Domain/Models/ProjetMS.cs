using System;
using System.Collections.Generic;
using System.Text;

namespace Poulina.GestionMS.Domain.Models
{
   public class ProjetMS
    {
        public Guid Id { get; set; }
        public Guid IdProjet { get; set; }
        public Guid IdMS { get; set; }

        public virtual Projet Projets { get; set; }

        public virtual MS Microservices { get; set; }


    }
}