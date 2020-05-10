using System;
using System.Collections.Generic;

namespace coreTest3Api.Models
{
    public partial class Absence
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public int? IdEtud { get; set; }
        public int? IdSeance { get; set; }

        public virtual Etudiant IdEtudNavigation { get; set; }
        public virtual Seance IdSeanceNavigation { get; set; }
    }
}
