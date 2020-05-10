using System;
using System.Collections.Generic;

namespace coreTest3Api.Models
{
    public partial class Enseignant
    {
        public Enseignant()
        {
            Matiere = new HashSet<Matiere>();
            Seance = new HashSet<Seance>();
        }

        public int Id { get; set; }
        public string Cin { get; set; }
        public DateTime? DateNais { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Genre { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public DateTime? DateEmb { get; set; }
        public string Cnss { get; set; }
        public double? Salaire { get; set; }

        public virtual ICollection<Matiere> Matiere { get; set; }
        public virtual ICollection<Seance> Seance { get; set; }
    }
}
