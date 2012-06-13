using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlertAgent
{
    public class InformationMessage : Message
    {
        public InformationMessage(List<string> destinaires, string sujet, string corps, bool aquittement, int dureeAffichage)
            : base(destinaires, sujet, corps, aquittement, dureeAffichage)
        {
        }
    }
}
