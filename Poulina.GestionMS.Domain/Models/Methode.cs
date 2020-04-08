using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Poulina.GestionMS.Domain.Models
{
    public class Methode
    {
        [Key]
        public Guid IdMethod { get; set; }

        public string Nom { get; set; }
        public string Description { get; set; }
        public string Input { get; set; }
        public string Output { get; set; }

        public MS Microservices { get; set; }

        public Guid FK_MS { get; set; }

    }
}
