using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk__Davidson
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
            sMaterial.DataSource = Enum.GetValues(typeof(SurfaceMaterial));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)   
        {
           
            string material = sMaterial.SelectedItem.ToString();
            var path = @"..\..\Data\newQuotes.json";
            var quotes = JsonConvert.DeserializeObject<List<DeskQuote>>(File.ReadAllText(path));
            var filteredQuotes = quotes.Where(q => q.newDesk.DeskMaterial == material).ToList();
            /*dataGridView1.DataSource = filteredQuotes;*/
            

            int count = filteredQuotes.Count;
            if (count == 0)
            {
                MessageBox.Show("No quotes found for this material");
            }
            else
            {
                dataGridView1.DataSource = filteredQuotes;
            }

        }
      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void closeSearch_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Close();
        }
    }
}
