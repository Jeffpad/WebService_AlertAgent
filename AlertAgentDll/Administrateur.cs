using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlertAgent
{
    public class Administrateur : Utilisateur
    {
        public static string _motDePasse= "admin";

        public Administrateur(string nomUtilisateur)
            : base(nomUtilisateur)
        {
        }

    }
}
