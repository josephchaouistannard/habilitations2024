using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using habilitations2024.dal;
using habilitations2024.model;

namespace habilitations2024.controller
{
    public class FrmAuthentificationController
    {
        private readonly DeveloppeurAccess developpeurAccess;

        public FrmAuthentificationController()
        {
            developpeurAccess = new DeveloppeurAccess();
        }

        public bool ControleAuthenitifcation(Admin admin)
        {
           return developpeurAccess.ControleAuthentification(admin);
        }
    }
}
