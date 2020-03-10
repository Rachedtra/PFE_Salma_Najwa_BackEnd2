using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Poulina.GestionMS.Domain.Models
{
    public class Domaine
    {
        [Key]
        public Guid Id { get; set; }

        public string Nom { get; set; }
        public ICollection<MS> Microservice { get; set; }



    }
}
