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
            string selectedMaterial = sMaterial.SelectedItem.ToString();
            string[] lines = File.ReadAllLines(@"quotes.json");
            List<DeskQuote> quotes = new List<DeskQuote>();
           
            foreach (string line in lines)
            {
                quotes.Add(JsonConvert.DeserializeObject<DeskQuote>(line));
            }

            var filteredQuotes = quotes.Where(q => q.newDesk.DeskMaterial == selectedMaterial).ToList();

            if (filteredQuotes.Count > 0)
            {
                dataGridView1.DataSource = filteredQuotes;
            }
            else
            {
                MessageBox.Show("No quotes found for the selected material");
            }

            dataGridView1.DataSource = filteredQuotes;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
