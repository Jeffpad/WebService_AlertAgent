using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlertAgent
{
    public class Message
    {
        private List<string> _destinataires;
        private string _sujet;
        private string _corps;
        private bool _acquittement;
        private int _dureeAffichage;

        public List<string> Destinataires
        {
            get
            {
                return this._destinataires;
            }
            set
            {
                this._destinataires = value;
            }
        }

        public string Sujet
        {
            get
            {
                return this._sujet;
            }
            set
            {
                this._sujet = value;
            }
        }

        public string Corps
        {
            get
            {
                return this._corps;
            }
            set
            {
                this._corps = value;
            }
        }
        public bool Acquittement
        {
            get
            {
                return this._acquittement;
            }
            set
            {
                this._acquittement = value;
            }
        }
        public int DureeAffichage
        {
            get
            {
                return this._dureeAffichage;
            }
            set
            {
                this._dureeAffichage = value;
            }
        }

        public Message(List<string> destinataires, string sujet, string corps, bool acquittement, int dureeAffichage)
        {
            this._destinataires = destinataires;
            this._sujet = sujet;
            this._corps = corps;
            this._acquittement = acquittement;
            this._dureeAffichage = dureeAffichage;
        }
    }
}
