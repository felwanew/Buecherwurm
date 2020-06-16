using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Bücherwurmneu
{
    public class JSONString
    {
        public static List<Buch> ErstelleKatalog(Bücherkatalog bücherkatalog)
        {
            var json = File.ReadAllText(@"C:\Users\wanwitfe\source\repos\ExersiceJSON\ExersiceJSON\Buecherei\books.json");
            return bücherkatalog.KatalogBücher = JsonConvert.DeserializeObject<List<Buch>>(json);
        }
        static public void SpeichereBücherkatalog(List<Buch> BücherListe)
        {
            string json = JsonConvert.SerializeObject(BücherListe);
            System.IO.File.WriteAllText(@"C:\Users\wanwitfe\source\repos\ExersiceJSON\ExersiceJSON\Buecherei\books.json", json);
        }
        public static List<Exemplar> ErstelleInventar(List<Exemplar> ExemplarListe)
        {
            string json = JsonConvert.SerializeObject(ExemplarListe);
            System.IO.File.WriteAllText(@"C:\Users\wanwitfe\source\repos\ExersiceJSON\ExersiceJSON\Buecherei\exemplare.json", json);
        }

        /*
        jsonString = JsonSerializer.Serialize(weatherForecast);

        jsonString = JsonSerializer.Serialize(weatherForecast);
        File.WriteAllText(fileName, jsonString);*/
    }
}

