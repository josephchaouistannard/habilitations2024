using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace habilitations2024.model
{
    public class Developpeur
    {
        public int Iddeveloppeur { get; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public string Pwd { get; set; }
        public Profil Profil { get; set; }

        public Developpeur(int iddeveloppeur, string nom, string prenom, string tel, string mail, string pwd, Profil profil)
        {
            this.Iddeveloppeur = iddeveloppeur;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Tel = tel;
            this.Mail = mail;
            this.Pwd = pwd;
            this.Profil = profil;
        }
    }
}
