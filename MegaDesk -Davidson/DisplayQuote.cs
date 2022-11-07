using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json;
using MegaDesk__TeamAngeles;

namespace MegaDesk__Davidson
{
    public partial class DisplayQuote : Form

    {
        private  DeskQuote deskQuote = new DeskQuote();
       



        public DisplayQuote(DeskQuote deskQuote)
        {

            InitializeComponent();
            this.deskQuote = deskQuote;
            
            
        }

        
      

        private void DisplayQuote_Load(object sender , EventArgs e)
        {
            customerNameQuote.Text = deskQuote.CustomerName;
            widthQuote.Text = deskQuote.newDesk.DeskWidth.ToString();
            depthQuote.Text = deskQuote.newDesk.DeskDepth.ToString();
            drawersQuote.Text = deskQuote.newDesk.NumDrawers.ToString();
            materialQuote.Text = deskQuote.newDesk.DeskMaterial;
            rushQuote.Text = deskQuote.RushDays.ToString();
            totalQuote.Text = "$ " + deskQuote.QuotePrice.ToString();
            dateForQuote.Text = deskQuote.QuoteDate;

        }

        
       
        private void closeQuote_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Close();
        }

        private void customerNameQuote_TextChanged(object sender, EventArgs e)
        {
            



        }
      

        public void saveOrder_Click(object sender, EventArgs e)
        {

            var path = @"..\..\Quotes\newQuotes.json";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            var quotes = JsonConvert.DeserializeObject<List<DeskQuote>>(File.ReadAllText(path));
            quotes.Add(deskQuote);
            File.WriteAllText(path, JsonConvert.SerializeObject(quotes, Formatting.Indented));

            MessageBox.Show("Quote saved");


        }

        private void DisplayQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
