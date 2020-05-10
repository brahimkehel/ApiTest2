using System;
using System.Collections.Generic;

namespace coreTest3Api.Models
{
    public partial class AnneeScolaire
    {
        public AnneeScolaire()
        {
            Classe = new HashSet<Classe>();
        }

        public int Id { get; set; }
        public string Annee { get; set; }

        public virtual ICollection<Classe> Classe { get; set; }
    }
}
