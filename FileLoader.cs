using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TipsMaskinen1
{
    class FileLoader // En klass som hanterar importering av data från en textfil till sträng.
    {
        private List<string> readLines;
        // denna lista Importerar textraderna och spara dem som böcker. 
        public void ReadFile()
        {
            // om filen finns så sparas den. filen är sparad i programmets debug.
            if (File.Exists("texter.txt"))
            {
                // en lista skapas 
                readLines = new List<string>();
                // här skapar jag en instans
                StreamReader reader = new StreamReader("texter.txt", Encoding.Default, true);
                string item;
                // while loopen jag använder här läser textfilen rad för rad
                while ((item = reader.ReadLine()) != null)
                {
                    // denna kod läser en rad från filen och returnerar det som en sträng
                    readLines.Add(item);
                }
                reader.Close(); // Därefter stänger jag filen så att andra program också kan få tillgång till filen.
            }
            else // om inte filen hittas skapas den här.
            {
                File.CreateText("texter.txt");
            }
        }
        // metod för att slumpa fram böckerna
        public List<Bok> SlumpaBöcker()
        {
            List<Bok> listOfBooks = new List<Bok>();
            // loopar igenom raderna. denna typ används när man arbetar med array eller listor
            foreach (string lines in readLines)
            {// skapar en array som gör en split metod
                // en split metod delar en sträng till småsträngar-substrings
                // och separerar fyrkanterna från strängen och skriver ut resultatet.
                string[] vektor = lines.Split(new string[] { "###" }, StringSplitOptions.None);
                string titel = vektor[0];
                string författare = vektor[1];
                string typ = vektor[2];
                string tillgänglig = vektor[3];
                // här gör jag en if sats som skriver ut böckerna baserat på dess boktyp.
                if (typ == "Novellsamling")
                {
                    Bok bok = new Novell(titel, författare, tillgänglig=="true");
                    listOfBooks.Add(bok);
                }
                else if (typ == "Tidskrift")
                {
                    Bok bok = new Tidsskrift(titel, författare, tillgänglig == "true");
                    listOfBooks.Add(bok);
                }
                else if (typ == "Roman")
                {
                    Bok bok = new Roman(titel, författare, tillgänglig == "true");
                    listOfBooks.Add(bok);
                }
            }
            // returnerar slutligen listan
            return listOfBooks;
        }
    }
}
