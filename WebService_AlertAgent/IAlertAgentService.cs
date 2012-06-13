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
        [OperationContract]
        void ajouterUtilisateur(string nomUtilisateur);

        [OperationContract]
        bool supprimerUtilisateur(string nomUtilisateur);

        [OperationContract]
        bool connexionAdmin(string nomUtilisateur, string motDePasse);

        [OperationContract]
        bool deconnexionAdmin(string nomUtilisateur);

        [OperationContract]
        void envoyerMessage(List<string> destinataires, int typeMessage, string sujet, string corps, bool acquittement, int dureeAffichage);
    }
}
