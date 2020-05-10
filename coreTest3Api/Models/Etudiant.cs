﻿using System;
using System.Collections.Generic;

namespace coreTest3Api.Models
{
    public partial class Etudiant
    {
        public Etudiant()
        {
            Absence = new HashSet<Absence>();
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
        public string Cne { get; set; }
        public string MotdePasse { get; set; }
        public int? IdFiliere { get; set; }

        public virtual Filiere IdFiliereNavigation { get; set; }
        public virtual ICollection<Absence> Absence { get; set; }
    }
}
