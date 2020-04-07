using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Poulina.GestionMS.Domain.Models
{
    public class Language
    {
  
        [Key]
        public Guid IdLanguage { get; set; }

        public string Label { get; set; }

        public ICollection<VersionLanguage> LanguageVersions { get; set; }

        public ICollection<MS> Microservices { get; set; }


    }
}

