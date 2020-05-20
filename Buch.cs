using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Bücherwurmneu
{
    public class Buch
    {

        public string Autor { get; set; }
        public string Land { get; set; }
        public string Bildlink { get; set; }
        public string Sprache { get; set; }
        public string Link { get; set; }
        public int Seiten { get; set; }
        public string Titel { get; set; }
        public int Erscheinungsjahr { get; set; }

    }
}
