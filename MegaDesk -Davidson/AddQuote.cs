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

        DeskQuote quoteInfo = new DeskQuote();
        Desk deskInfo = new Desk();
        DisplayQuote newInfo = new DisplayQuote();


        public AddQuote()
        {
            InitializeComponent();
            SelectedMaterial.DataSource = Enum.GetValues(typeof(SurfaceMaterial));
            ShipRushDays.DataSource = Enum.GetValues(typeof(shipDays));

           
        }









        private void cancelBtn_Click_1(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Tag;
            this.customerNameInput.CausesValidation = false;
            
            this.DeskWidthInput.CausesValidation = false;
            this.DeskDepthInput.CausesValidation = false;
            this.NumDrawersInput.CausesValidation = false;
            this.SelectedMaterial.CausesValidation = false;
            mainMenu.Show();
            Close();

        }
        
        private void submitBtn_Click(object sender, EventArgs e)
        {
            DeskQuote quoteInfo = new DeskQuote();
            Desk deskInfo = new Desk();
           


            deskInfo.DeskWidth = Int32.Parse(DeskWidthInput.Text);
            
            deskInfo.DeskDepth = Int32.Parse(DeskDepthInput.Text);
            deskInfo.NumDrawers = Int32.Parse(NumDrawersInput.Text);


            //Grab the info from the form
            DisplayQuote newInfo = new DisplayQuote();
            quoteInfo.CustomerName = customerNameInput.Text;

            newInfo.customerName = customerNameInput.Text;

            deskInfo.DeskWidth = Int32.Parse(DeskWidthInput.Text);
            deskInfo.DeskDepth = Int32.Parse(DeskDepthInput.Text);
            deskInfo.NumDrawers = Int32.Parse(NumDrawersInput.Text);
             deskInfo.DeskMaterial = SelectedMaterial.Text;
             quoteInfo.RushDays = 0;
            if (ShipRushDays.Text == "Three" )
            {
                quoteInfo.RushDays = 3;

            }
            else if(ShipRushDays.Text == "Five")
            {
                quoteInfo.RushDays = 5;
            }
            else if(ShipRushDays.Text == "Seven")
            {
                quoteInfo.RushDays = 7;
            }
            else
            {
                quoteInfo.RushDays = 14;
            }

            var m = new DisplayQuote();
            m.Show();
            Close();


        }

        private void FirstNameInput_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(customerNameInput.Text))
            {
                e.Cancel = true;
                customerNameInput.Focus();
                errorCname.SetError(customerNameInput, "Please enter your First Name");
         
            }
            else
            {
                e.Cancel = false;
                errorCname.SetError(customerNameInput, null);

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
