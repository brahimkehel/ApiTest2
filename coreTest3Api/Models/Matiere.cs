using System;
using System.Collections.Generic;

namespace coreTest3Api.Models
{
    public partial class Matiere
    {
        public Matiere()
        {
            Seance = new HashSet<Seance>();
        }

        public int Id { get; set; }
        public string Libelle { get; set; }
        public int? IdEns { get; set; }

        public virtual Enseignant IdEnsNavigation { get; set; }
        public virtual ICollection<Seance> Seance { get; set; }
    }
}
