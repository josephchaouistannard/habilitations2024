using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace habilitations2024.model
{
    public class Admin
    {
        public string Nom { get; }
        public string Prenom { get; }
        public string Pwd { get; }

        public Admin(string nom, string prenom, string pwd)
        {
            Nom = nom;
            Prenom = prenom;
            Pwd = pwd;
        }
    }
}
