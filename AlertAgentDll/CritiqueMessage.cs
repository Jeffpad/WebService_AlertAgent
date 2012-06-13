using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlertAgent
{
    public class CritiqueMessage : Message
    {
        public CritiqueMessage(List<string> destinaires, string sujet, string corps, int dureeAffichage)
            : base(destinaires, sujet, corps, true, dureeAffichage)
        {
        }
    }
}
