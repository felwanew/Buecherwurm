using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Bücherwurmneu
{
    
    public class Program
    {


        
        static public void Main(string[] args)
        {
            Bücherkatalog bücherkatalog = new Bücherkatalog();
            Inventar inventar = new Inventar();
            Ausgeliehen ausgeliehen = new Ausgeliehen();
            ErstelleKatalog(bücherkatalog);
            bool Beenden = false;
            string Auswahl;
            while (Beenden == false)
            {
                bool OffenUnterprogramm = true;
                string ZuBearbeiteneKategorie;
                Auswahloptionen();
                Auswahl = Console.ReadLine();
                if (Auswahl == "b")
                {
                    ZuBearbeiteneKategorie = "Buch";
                    while (OffenUnterprogramm == true)
                    {
                        Auswahl = AuswahloptionenUnterprogrammCrud(Auswahl, ZuBearbeiteneKategorie);
                        if (Auswahl == "c")
                            bücherkatalog.BuchHinzufügen(inventar);
                        else if (Auswahl == "r")
                            bücherkatalog.Lesen();
                        else if (Auswahl == "u")
                            bücherkatalog.Bearbeiten();
                        else if (Auswahl == "d")
                            bücherkatalog.Löschen();
                        else if (Auswahl == "q")
                            OffenUnterprogramm = false;
                        else
                            Console.WriteLine("Eingabe ungültig");
                    }
                }
                else if (Auswahl == "e")
                {
                    ZuBearbeiteneKategorie = "Exemplar";
                    while (OffenUnterprogramm == true)
                    {
                        Auswahl = AuswahloptionenUnterprogrammCrud(Auswahl, ZuBearbeiteneKategorie);
                        if (Auswahl == "c")
                            inventar.ExemplarHinzufügen(bücherkatalog);
                        else if (Auswahl == "r")
                            inventar.Lesen();
                        else if (Auswahl == "u")
                            inventar.Bearbeiten();
                        else if (Auswahl == "d")
                            inventar.Löschen();
                        else if (Auswahl == "q")
                            OffenUnterprogramm = false;
                        else
                            Console.WriteLine("Eingabe ungültig");
                    }
                    
                }
                else if (Auswahl == "a")
                {
                    ZuBearbeiteneKategorie = "Ausleihe";
                    while (OffenUnterprogramm == true)
                    {
                        Auswahl = AuswahloptionenUnterprogrammCrud(Auswahl, ZuBearbeiteneKategorie);
                       if (Auswahl == "c")
                            ausgeliehen.AusleiheHinzufügen(inventar);
                        else if (Auswahl == "r")
                            ausgeliehen.Lesen();
                        else if (Auswahl == "u")
                            ausgeliehen.Bearbeiten();
                        else if (Auswahl == "d")
                            ausgeliehen.Löschen();
                        else if (Auswahl == "q")
                            OffenUnterprogramm = false;
                        else
                            Console.WriteLine("Eingabe ungültig");
                    }
                }
                else if (Auswahl == "q")
                {
                    Beenden = true;
                }
                else
                {
                    Console.Write("\nungültige Eingabe\nBitte nochmal versuchen");
                }
                JSONString.WriteJSON(bücherkatalog);
            }

            string AuswahloptionenUnterprogrammCrud(string Auswahl, string ZuBearbeiteneKategorie)
            {
                Console.Write(ZuBearbeiteneKategorie + "-Menü\n");
                Console.Write("=========================================================================\n");
                Console.Write("Für das Anlegen eines neuen Eintrags 'c' eingeben\n");
                Console.Write("Für das Auslesen aller Einträge 'r' eingeben\n");
                Console.Write("Für das Bearbeiten eines Eintrags 'u' eingeben\n");
                Console.Write("Für das Löschen eines Eintrags 'd' eingeben\n");
                Console.Write("Für das Beenden des Unterprogramms 'q' eingeben\n");
                return Auswahl = Console.ReadLine();
            }
        }
        static public void Auswahloptionen()
        {

            Console.Write("\nBücherverleih Bücherwurm\n");
            Console.Write("\nFür die Liste der Bücher 'b' eingeben\n");
            Console.Write("Für die Liste der Exemplare 'e' eingeben\n");
            Console.Write("Für die Liste der Ausleihe 'a' eingeben\n");
            Console.Write("Für das Beenden des Programms 'q' eingeben\n");
        }
    }
}
