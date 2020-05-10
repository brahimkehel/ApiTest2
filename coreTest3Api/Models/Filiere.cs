using System;
using System.Collections.Generic;

namespace coreTest3Api.Models
{
    public partial class Filiere
    {
        public Filiere()
        {
            Classe = new HashSet<Classe>();
            Etudiant = new HashSet<Etudiant>();
        }

        public int Id { get; set; }
        public string Libelle { get; set; }

        public virtual ICollection<Classe> Classe { get; set; }
        public virtual ICollection<Etudiant> Etudiant { get; set; }
    }
}
