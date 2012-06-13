using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlertAgent
{
    public class Utilisateur
    {
        private string _nomUtilisateur;

        public string NomUtilisateur
        {
            get
            {
                return _nomUtilisateur;
            }
            set
            {
                _nomUtilisateur = value;
            }
        }

        public Utilisateur(string nomUtilisateur)
        {
            this._nomUtilisateur = nomUtilisateur;
        }
    }
}
