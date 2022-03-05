using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipsMaskinen1
{
    public partial class Form1 : Form
    {
        private List<Bok> boklista; // listan som innehåller böcker
        public static Random slumptal; // Egenskapen som slumpar fram någpt.
        
        public Form1()
        {
            slumptal = new Random(); // Deklarerar slumptal som en ny random
            InitializeComponent();
            FileLoader filen = new FileLoader(); // Lista av min filladdare
            filen.ReadFile(); // läser in filen
            boklista = filen.SlumpaBöcker(); // boklistan innehåller filladdaren som slumpar böcker
            int siffra = slumptal.Next(0, boklista.Count); // heltal som slumpar fram boklistans innehåll
            textRuta.Text = boklista[siffra].ToString(); // slumpade böcker visas i textrutan.
        }

        
        // knappen nytt boktips som slumpar fram böcker.
        private void button1_Click(object sender, EventArgs e)
        {
            int siffra = slumptal.Next(0, boklista.Count); // slumpar fram listans innehåll
            textRuta.Text = boklista[siffra].ToString(); //  slumpvald boks ToString-override
        }
    }
}
