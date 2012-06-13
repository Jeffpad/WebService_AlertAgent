using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using AlertAgent;

namespace WebService_AlertAgent
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    public class AlertAgentService : IAlertAgentService
    {
        private List<Utilisateur> _listeUtilisateurs;
        private List<Message> _listeMessages;
        private Message _message;

        public List<Utilisateur> UsersList
        { 
            get
            {
                return _listeUtilisateurs;
            }
        }
     
        public void ajouterUtilisateur(string nomUtilisateur)
        {
            _listeUtilisateurs.Add(new Utilisateur(nomUtilisateur));
        }

        public bool supprimerUtilisateur(string nomUtilisateur)
        {
            return _listeUtilisateurs.Remove(_listeUtilisateurs[2]);
        }

        public bool connexionAdmin(string nomUtilisateur, string motDePasse)
        {
            for (int i = 0; i < _listeUtilisateurs.Count; i++)
            {
                if (_listeUtilisateurs[i].NomUtilisateur == nomUtilisateur)
                {
                    if (Administrateur._motDePasse == motDePasse)
                    {
                        _listeUtilisateurs[i] = new Administrateur(nomUtilisateur);
                        return true;
                    }
                }
            }

            return false;
        }

        public bool deconnexionAdmin(string nomUtilisateur)
        {
            for (int i = 0; i < _listeUtilisateurs.Count; i++)
            {
                if (_listeUtilisateurs[i].NomUtilisateur == nomUtilisateur)
                {
                    _listeUtilisateurs[i] = new Utilisateur(nomUtilisateur);
                    return true;
                }
            }

            return false;


        }

        public void envoyerMessage(List<string> destinataires, int typeMessage, string sujet, string corps, bool acquittement, int dureeAffichage)
        {
            switch (typeMessage)
            {
                case 1:
                    {
                        _message = new InformationMessage(destinataires, sujet, corps, acquittement, dureeAffichage);
                        break;
                    }
                case 2:
                    {
                        _message = new AvertissementMessage(destinataires, sujet, corps, acquittement, dureeAffichage);
                        break;
                    }
                case 3:
                    {
                        _message = new CritiqueMessage(destinataires, sujet, corps, dureeAffichage);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        public List<Message> recevoirMessages(string nomUtilisateur)
        {
            List<Message> messagesRecus = null;

            for (int i = 0; i < _listeMessages.Count; i++) 
            {
                for (int j = 0; j < _listeMessages[i].Destinataires.Count; j++)
                {
                    if (_listeMessages[i].Destinataires[j] == nomUtilisateur)
                    {
                        messagesRecus.Add(_listeMessages[i]);
                    }
                }
            }

            return messagesRecus;
        }
    }
}
