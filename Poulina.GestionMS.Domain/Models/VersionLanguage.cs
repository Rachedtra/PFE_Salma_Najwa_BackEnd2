using System;
using System.Collections.Generic;
using System.Text;

namespace Poulina.GestionMS.Domain.Models
{
   public class VersionLanguage
    {
        public Guid Id { get; set; }
        public Guid IdL { get; set; }
        public Guid IdVersion { get; set; }

        public virtual Versions Versions { get; set; }
        public Guid FK_V { get; set; }

        public virtual Language Languages { get; set; }
        public Guid FK_L { get; set; }

    }
}
