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


            var newQuote = new List<DeskQuote>
            {
                new DeskQuote
                {
                    CustomerName = deskQuote.CustomerName,
                    QuoteDate = deskQuote.QuoteDate,
                    RushDays = deskQuote.RushDays,
                    newDesk = deskQuote.newDesk,
                    DrawerCost = deskQuote.DrawerCost,
                    QuotePrice = deskQuote.QuotePrice,
                    RushCost = deskQuote.RushCost,
                    MaterialCost = deskQuote.MaterialCost,
                    SurfaceArea = deskQuote.SurfaceArea,
                    SizeCost = deskQuote.SizeCost
                }
            };
        
            string s = JsonConvert.SerializeObject(newQuote, Formatting.Indented);
            File.WriteAllText(@"quotes.json", s);
            var writer = new StreamWriter(@"quotes.json");
            writer.Write(s);
            writer.Close();
            MessageBox.Show("Your order has been saved");
            
            

        }

        private void DisplayQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
