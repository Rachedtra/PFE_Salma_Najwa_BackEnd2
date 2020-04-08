using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Poulina.GestionMS.Domain.Models
{
    public class MS
    {
        [Key]
        public Guid IdMS { get; set; }

        public string Label { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Lien { get; set; }
        public string DiagClass { get; set; }

        public ICollection<ProjetMS> ProjetMs { get; set; }

        public virtual ICollection<Methode> Methods { get; set; }

        public Language Languages { get; set; }


        public Guid LanguageFK { get; set; }

    }
}

