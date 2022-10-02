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

namespace MegaDesk__Davidson
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote()
        {
            InitializeComponent();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            

        }

       /* public string FirstName
        {
            get { return firstNameQuote.Text; }
        }
        public string LastName
        {
            get { return lastNameQuote.Text; }
        }
        public string Width
        {
            get { return widthQuote.Text; }
        }

        
        public string Depth
        {
            get { return depthQuote.Text; }
          }
        
    
        public string Drawers
        {
            get { return drawersQuote.Text; }
        }
        public string Material
        {
            get { return materialQuote.Text; }
        }
        public string Rush
        {
            get { return rushQuote.Text; }
        }*/
        private void closeQuote_Click(object sender, EventArgs e)
        {
            var m = new MainMenu();
            m.Show();
            Close();
        }

       
    }
}
