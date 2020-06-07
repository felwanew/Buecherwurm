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
        string jsonString;
        string FileName = "C:\\Users\\Felix\\source\\repos\\ZwischenstandZenker\\Buecherei\\books.json";
        public void ErstelleKatalog(Bücherkatalog bücherkatalog)
        {
            jsonString = File.ReadAllText(FileName);
            bücherkatalog.KatalogBücher = JsonSerializer.Deserialize<Buch>(jsonString);
        }
        
        /*
        jsonString = JsonSerializer.Serialize(weatherForecast);

        jsonString = JsonSerializer.Serialize(weatherForecast);
        File.WriteAllText(fileName, jsonString);*/
    }
}

