using System;
using System.Collections.Generic;
using System.Text;

namespace Poulina.GestionMS.Domain.Models
{
   public class VersionLanguage
    {
        public Guid IDV { get; set; }
        public Guid LDV { get; set; }
        public Guid Id { get; set; }

        public virtual Versions Versions { get; set; }

        public virtual Language Languages{ get; set; }



    }
}
