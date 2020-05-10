using System;
using System.Collections.Generic;

namespace coreTest3Api.Models
{
    public partial class Seance
    {
        public Seance()
        {
            Absence = new HashSet<Absence>();
        }

        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public int? IdClasse { get; set; }
        public int? IdEns { get; set; }
        public string Sujet { get; set; }
        public int? IdMat { get; set; }

        public virtual Classe IdClasseNavigation { get; set; }
        public virtual Enseignant IdEnsNavigation { get; set; }
        public virtual Matiere IdMatNavigation { get; set; }
        public virtual ICollection<Absence> Absence { get; set; }
    }
}
