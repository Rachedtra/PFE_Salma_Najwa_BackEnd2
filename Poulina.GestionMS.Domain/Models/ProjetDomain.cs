using System;
using System.Collections.Generic;
using System.Text;

namespace Poulina.GestionMS.Domain.Models
{
    public class ProjetDomain
    {
        public Guid Id { get; set; }
        public Guid IdDomaine { get; set; }
        public Guid IdProjet { get; set; }

        public virtual Domaine Domaine { get; set; }

        public virtual Projet Projets { get; set; }
    }
}
