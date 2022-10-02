using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MegaDesk__Davidson
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            selectedMaterial.DataSource = Enum.GetValues(typeof(SurfaceMaterial));
            shipRushDays.DataSource = Enum.GetValues(typeof(shipDays));
       
            
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }

        
      


        private void cancelBtn_Click_1(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(FirstNameInput.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(LastNameInput.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(DeskWidthInput.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(DeskDepthInput.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(NumDrawersInput.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void FirstNameInput_Validating(object sender, CancelEventArgs e)
        { 
             if (string.IsNullOrEmpty(FirstNameInput.Text))
            {
                e.Cancel = true;
                FirstNameInput.Focus();
                errorProvider.SetError(FirstNameInput, "Please enter your first name");
            } else
            {
                e.Cancel = false;
                errorProvider.SetError(FirstNameInput, null);
            }

        }

        private void LastNameInput_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(LastNameInput.Text))
            {
                e.Cancel = true;
                LastNameInput.Focus();
                errorProvider.SetError(LastNameInput, "Please enter your last name");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(LastNameInput, null);
            }

        }

        private void DeskWidthInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(DeskWidthInput.Text))
            {
                e.Cancel = true;
                DeskWidthInput.Focus();
                errorProvider.SetError(DeskWidthInput, "Please enter a width");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(DeskWidthInput, null);
            }
        }

        private void DeskDepthInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(DeskDepthInput.Text))
            {
                e.Cancel = true;
                DeskDepthInput.Focus();
                errorProvider.SetError(DeskDepthInput, "Please enter your the depth");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(DeskDepthInput, null);
            }

        }

        private void NumDrawersInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(NumDrawersInput.Text))
            {
                e.Cancel = true;
                NumDrawersInput.Focus();
                errorProvider.SetError(NumDrawersInput, "Please enter your the number of drawers");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(NumDrawersInput, null);
            }

        }
    }

    public enum shipDays
    {
        Three,
        Five,
        Seven,
        None
    }
}
