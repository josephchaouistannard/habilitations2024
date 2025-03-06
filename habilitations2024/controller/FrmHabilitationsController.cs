using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using habilitations2024.dal;
using habilitations2024.model;

namespace habilitations2024.controller
{
    public class FrmHabilitationsController
    {
        private readonly DeveloppeurAccess developpeurAccess;
        private readonly ProfilAccess profilAccess;

        public FrmHabilitationsController()
        {
            developpeurAccess = new DeveloppeurAccess();
            profilAccess = new ProfilAccess();
        }

        public List<Developpeur> GetLesDeveloppeurs(List<Profil> lesProfils)
        {
            return developpeurAccess.GetLesDeveloppeurs(lesProfils);
        }

        public List<Profil> GetLesProfils()
        {
            return profilAccess.GetLesProfils();
        }

        public void DelDeveloppeur(Developpeur dev)
        {
            developpeurAccess.DelDeveloppeur(dev);
        }

        public void AddDeveloppeur(Developpeur dev)
        {
            developpeurAccess.AddDeveloppeur(dev);
        }

        public void UpdateDeveloppeur(Developpeur dev)
        {
            developpeurAccess.UpdateDeveloppeur(dev);
        }

        public void UpdatePwd(Developpeur dev)
        {
            developpeurAccess.UpdatePwd(dev);
        }
    }
}
