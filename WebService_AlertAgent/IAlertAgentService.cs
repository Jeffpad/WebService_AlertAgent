using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebService_AlertAgent
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IAlertAgentService
    {
        public void ajouterUtilisateur(string nomUtilisateur);
        public bool supprimerUtilisateur(string nomUtilisateur);
        public bool connexionAdmin(string nomUtilisateur, string motDePasse);
        public bool deconnexionAdmin(string nomUtilisateur);
        public void envoyerMessage(List<string> destinataires, int typeMessage, string sujet, string corps, bool acquittement, int dureeAffichage);
    }
}
