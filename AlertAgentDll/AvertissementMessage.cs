using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlertAgent
{
    public class AvertissementMessage : Message
    {
        public static string urlIconAvertissement = "";

        public AvertissementMessage(List<string> destinaires, string sujet, string corps, bool aquittement, int dureeAffichage)
            : base(destinaires, sujet, corps, aquittement, dureeAffichage)
        {
        }
    }
}
