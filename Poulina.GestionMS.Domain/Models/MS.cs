using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Poulina.GestionMS.Domain.Models
{
    public class MS
    {

        [Key]
        public Guid Id { get; set; }

        public string Label { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Lien { get; set; }
        public string DiagClass { get; set; }
        public Domaine Domaine { get; set; }

        public Guid DomaineFK { get; set; }
        public ICollection<Methode> Methodes { get; set; }
        public Language Language { get; set; }

        public Guid LanguageFK { get; set; }




    }
}
