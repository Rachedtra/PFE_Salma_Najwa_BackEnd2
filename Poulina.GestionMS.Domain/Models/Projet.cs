using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Poulina.GestionMS.Domain.Models
{
   public class Projet
    {
        [Key]

        public Guid IdProjet { get; set; }

        public string Nom { get; set; }

        public string Description { get; set; }

        public virtual ICollection<ProjetDomain> ProjetDomains { get; set; }

        public ICollection<ProjetMS> ProjetMs { get; set; }


    }
}
