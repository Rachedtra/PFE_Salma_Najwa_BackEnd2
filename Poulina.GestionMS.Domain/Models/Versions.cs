using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Poulina.GestionMS.Domain.Models
{
    public class Versions
    {
        [Key]
        public Guid IDversion { get; set; }

        public int Numero { get; set; }

        public ICollection<VersionLanguage> LanguageVersions { get; set; }

    }
}
