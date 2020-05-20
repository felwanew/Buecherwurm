using System;
using System.Collections.Generic;
using System.Text;

namespace Bücherwurmneu
{
    public class Ausleihe
    {
        public Exemplar Exemplar { get; set; }
        public DateTime AnfangAusleih { get; set; }
        public DateTime EndeAusleih { get; set; }
        public string Kunde { get; set; }
    }
}
