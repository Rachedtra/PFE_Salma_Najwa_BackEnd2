using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Poulina.GestionMS.Domain.Models
{
    public class Versions
    {
        [Key]
        public Guid IDV { get; set; }

        public int Numero { get; set; }
        public ICollection<VersionLanguage> VersionLanguages { get; set; }

        public Guid VerFK { get; set; }
    }
}
