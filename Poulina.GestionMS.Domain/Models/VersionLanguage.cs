using System;
using System.Collections.Generic;
using System.Text;

namespace Poulina.GestionMS.Domain.Models
{
   public class VersionLanguage
    {
        public Guid Id { get; set; }
        public Guid IdLanguage { get; set; }
        public Guid IdVersion { get; set; }

        public virtual Versions Versions { get; set; }

        public virtual Language Languages { get; set; }
    }
}
