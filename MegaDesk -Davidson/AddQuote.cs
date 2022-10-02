using System;
using System.ComponentModel;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MegaDesk__Davidson
{
    public partial class AddQuote : Form
    {
       


        public AddQuote()
        {
            InitializeComponent();
            SelectedMaterial.DataSource = Enum.GetValues(typeof(SurfaceMaterial));
            ShipRushDays.DataSource = Enum.GetValues(typeof(shipDays));

           
        }


    

        
      


        private void cancelBtn_Click_1(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Tag;
            this.FirstNameInput.CausesValidation = false;
            this.LastNameInput.CausesValidation = false;
            this.DeskWidthInput.CausesValidation = false;
            this.DeskDepthInput.CausesValidation = false;
            this.NumDrawersInput.CausesValidation = false;
            this.SelectedMaterial.CausesValidation = false;
            mainMenu.Show();
            Close();

        }
        
        private void submitBtn_Click(object sender, EventArgs e)
        {
            //Grab the info from the form
            string firstName = FirstNameInput.Text;
            string lastName = LastNameInput.Text;
            int width = Int32.Parse(DeskWidthInput.Text);
            int depth = Int32.Parse(DeskDepthInput.Text);
            int drawers = Int32.Parse(NumDrawersInput.Text);
            string material = SelectedMaterial.Text;
            int rush = 0;
            if (ShipRushDays.Text == "Three" )
            {
                rush = 3;

            }
            else if(ShipRushDays.Text == "Five")
            {
                rush = 5;
            }
            else if(ShipRushDays.Text == "Seven")
            {
                rush = 7;
            }
            else
            {
                rush = 14;
            }

           



            Desk desk = new Desk(width, depth, drawers, rush);
            float surfaceArea = desk.GetSurfaceArea();

            


            //process data
            DeskQuote newQuote = new DeskQuote(firstName, lastName, width, drawers, material, rush);
            
            float quotePrice = newQuote.GetQuotePrice();
            float shipPrice = newQuote.calcShipping();
            float calMaterialPrice = newQuote.calcSurfaceMaterial();
            float drawerPrice = newQuote.calcDrawers();

            


            
          /*  using (DisplayQuote displayQuote = new DisplayQuote())
            {
                if (displayQuote.ShowDialog() == DialogResult.OK)
                {
                    firstName = displayQuote.FirstName;
                }
                if (displayQuote.ShowDialog() == DialogResult.OK)
                {
                    lastName = displayQuote.LastName;
                }
                if (displayQuote.ShowDialog() == DialogResult.OK)
                {
                    width = displayQuote.Width;
                }
                if (displayQuote.ShowDialog() == DialogResult.OK)
                {
                    depth = displayQuote.Depth;
                }
                if (displayQuote.ShowDialog() == DialogResult.OK)
                {
                    drawers = displayQuote.Drawers;
                }
                if (displayQuote.ShowDialog() == DialogResult.OK)
                {
                    material = displayQuote.Material;
                }
                if (displayQuote.ShowDialog() == DialogResult.OK)
                {
                    rush = displayQuote.Rush;
                }
            }*/
            var m = new DisplayQuote();
            m.Show();
            Close();


        }

        private void FirstNameInput_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(FirstNameInput.Text))
            {
                e.Cancel = true;
                FirstNameInput.Focus();
                errorFname.SetError(FirstNameInput, "Please enter your First Name");
         
            }
            else
            {
                e.Cancel = false;
                errorLname.SetError(LastNameInput, null);

            }
        }

        private void LastNameInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(LastNameInput.Text))
            {
                e.Cancel = true;
                LastNameInput.Focus();
                errorLname.SetError(LastNameInput, "Please enter your Last Name");
            }
            else
            {
                e.Cancel = false;
                errorLname.SetError(LastNameInput, null);

            }

        }

        private void DeskWidthInput_Validating(object sender, CancelEventArgs e)
        {
           
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

        }

        private void shipRushDays_Validating(object sender, CancelEventArgs e)
        {

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
