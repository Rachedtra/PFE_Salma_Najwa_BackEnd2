using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Poulina.GestionMS.Domain.Models
{
    public class Language
    {
        [Key]
        public Guid LDV { get; set; }

        public string Label { get; set; }
        public ICollection<MS> Microservice { get; set; }

        public ICollection<VersionLanguage> VersionLanguages { get; set; }

    }
}
