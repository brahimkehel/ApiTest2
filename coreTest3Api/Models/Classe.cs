using System;
using System.Collections.Generic;

namespace coreTest3Api.Models
{
    public partial class Classe
    {
        public Classe()
        {
            Seance = new HashSet<Seance>();
        }

        public int Id { get; set; }
        public string Libelle { get; set; }
        public int? IdAnnee { get; set; }
        public int? IdFiliere { get; set; }

        public virtual AnneeScolaire IdAnneeNavigation { get; set; }
        public virtual Filiere IdFiliereNavigation { get; set; }
        public virtual ICollection<Seance> Seance { get; set; }
    }
}
