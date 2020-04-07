using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Poulina.GestionMS.Domain.Models
{
    public class Domaine
    {
        [Key]
        public Guid IdDomaine { get; set; }

        public string Nom { get; set; }

        public virtual ICollection<ProjetDomain> ProjetDomains { get; set; }

    }
}