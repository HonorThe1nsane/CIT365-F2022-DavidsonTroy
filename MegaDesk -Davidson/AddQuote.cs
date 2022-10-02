using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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
            this.FirstNameInput.CausesValidation = false;
            this.LastNameInput.CausesValidation = false;
            this.DeskWidthInput.CausesValidation = false;
            this.DeskDepthInput.CausesValidation = false;
            this.NumDrawersInput.CausesValidation = false;
            this.selectedMaterial.CausesValidation = false;
            mainMenu.Show();
            Close();

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            DisplayQuote viewQuote = new DisplayQuote();
            viewQuote.Tag = this;
            viewQuote.Show(this);
            Hide();


        }

        private void FirstNameInput_Validating(object sender, CancelEventArgs e)
        { 
             if (string.IsNullOrEmpty(FirstNameInput.Text))
            {
                e.Cancel = true;
                FirstNameInput.Focus();
                errorFname.SetError(FirstNameInput, "Please enter your first name");
            } else
            {
                e.Cancel = false;
                errorFname.SetError(FirstNameInput, null);
            }


        }

        private void LastNameInput_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(LastNameInput.Text))
            {
                e.Cancel = true;
                LastNameInput.Focus();
                errorLname.SetError(LastNameInput, "Please enter your last name");
            }
            else
            {
                e.Cancel = false;
                errorLname.SetError(LastNameInput, null);
            }

        }

        private void DeskWidthInput_Validating(object sender, CancelEventArgs e)
        {
            bool res;
            if (string.IsNullOrEmpty(DeskWidthInput.Text))
            {
                e.Cancel = true;
                DeskWidthInput.Focus();
                errorWDesk.SetError(DeskWidthInput, "Please enter a width");
            }
            else if (DeskDepthInput.Text != null)
            {


                int number = Int32.Parse(DeskWidthInput.Text);
                if (number < 24 || number > 96)
                {
                    e.Cancel = true;
                    DeskWidthInput.Focus();
                    errorWDesk.SetError(DeskWidthInput, "Please enter a width between 24 inches and 96 inches");

                }
                else
                {
                    e.Cancel = false;
                    errorWDesk.SetError(DeskWidthInput, null);

                }

            }
            else
            {
                e.Cancel = false;
                errorWDesk.SetError(DeskWidthInput, null);

            }


        }

        private void DeskDepthInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(DeskDepthInput.Text))
            {
                e.Cancel = true;
                DeskDepthInput.Focus();
                errorDDesk.SetError(DeskDepthInput, "Please enter your the depth");
            }
            else if (Regex.IsMatch(DeskDepthInput.Text, @"^\d+$") != true)
            {
                e.Cancel = true;
                DeskDepthInput.Focus();
                errorDDesk.SetError(DeskDepthInput, "Please enter your the depth with a valid number");
            }

            else
            {

                int number = Int32.Parse(DeskDepthInput.Text);
                if (number < 12 || number > 48)
                {
                    e.Cancel = true;
                    DeskDepthInput.Focus();
                    errorDDesk.SetError(DeskDepthInput, "Please enter a width between 12 inches and 48 inches");

                }
                else
                {
                    e.Cancel = false;
                    errorDDesk.SetError(DeskDepthInput, null);

                }
            }


        }

        private void NumDrawersInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(NumDrawersInput.Text))
            {
                e.Cancel = true;
                NumDrawersInput.Focus();
                errorNumDrawers.SetError(NumDrawersInput, "Please enter your the number of drawers");
            }
            else if (NumDrawersInput.Text != null)
            {
                int number = Int32.Parse(NumDrawersInput.Text);
                if (number < 0 || number > 7)
                {
                    e.Cancel = true;
                    NumDrawersInput.Focus();
                    errorNumDrawers.SetError(NumDrawersInput, "Please enter a width between 12 inches and 48 inches");

                }
                else
                {
                    e.Cancel = false;
                    errorNumDrawers.SetError(NumDrawersInput, null);

                }

            }
            else
            {
                e.Cancel = false;
                errorNumDrawers.SetError(NumDrawersInput, null);

            }



        }

        private void selectedMaterial_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMaterial.Text))
            {
                e.Cancel = true;
                selectedMaterial.Focus();
                errorSurfMat.SetError(selectedMaterial, "Please select your desk material");
            }
            else
            {
                e.Cancel = false;
                errorSurfMat.SetError(selectedMaterial, null);
            }

        }

        private void shipRushDays_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(shipRushDays.Text))
            {
                e.Cancel = true;
                shipRushDays.Focus();
                errorRushDays.SetError(shipRushDays, "Please select your the number of rush days or select none");
            }
            else
            {
                e.Cancel = false;
                errorRushDays.SetError(shipRushDays, null);
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
