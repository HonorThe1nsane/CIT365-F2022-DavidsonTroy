using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MegaDesk__Davidson
{
    public partial class DisplayQuote : Form

        
    {

        DeskQuote quoteInfo = new DeskQuote();
        Desk deskInfo = new Desk();
        public string customerName;
        public DisplayQuote( )
        {
            InitializeComponent();
            
           

        }

        
      

        private void DisplayQuote_Load(object sender , EventArgs e)
        {
          

 



        }

        
       
        private void closeQuote_Click(object sender, EventArgs e)
        {
            var m = new MainMenu();
            m.Show();
            Close();
        }

        private void customerNameQuote_TextChanged(object sender, EventArgs e)
        {
            
            


        }
    }
}
