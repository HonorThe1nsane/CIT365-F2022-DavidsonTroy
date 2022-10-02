namespace MegaDesk__Davidson
{
    public class AddQuote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            this.RushDaysInput = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SurfaceMaterialInput = new System.Windows.Forms.TextBox();
            this.NumDrawersInput = new System.Windows.Forms.TextBox();
            this.DeskDepthInput = new System.Windows.Forms.TextBox();
            this.DeskWidthInput = new System.Windows.Forms.TextBox();
            this.FirstNameInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fullName = new System.Windows.Forms.Label();
            this.LastNameInput = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RushDaysInput
            // 
            this.RushDaysInput.FormattingEnabled = true;
            resources.ApplyResources(this.RushDaysInput, "RushDaysInput");
            this.RushDaysInput.Name = "RushDaysInput";
            this.RushDaysInput.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // SurfaceMaterialInput
            // 
            resources.ApplyResources(this.SurfaceMaterialInput, "SurfaceMaterialInput");
            this.SurfaceMaterialInput.Name = "SurfaceMaterialInput";
            // 
            // NumDrawersInput
            // 
            resources.ApplyResources(this.NumDrawersInput, "NumDrawersInput");
            this.NumDrawersInput.Name = "NumDrawersInput";
            // 
            // DeskDepthInput
            // 
            resources.ApplyResources(this.DeskDepthInput, "DeskDepthInput");
            this.DeskDepthInput.Name = "DeskDepthInput";
            // 
            // DeskWidthInput
            // 
            resources.ApplyResources(this.DeskWidthInput, "DeskWidthInput");
            this.DeskWidthInput.Name = "DeskWidthInput";
            // 
            // FirstNameInput
            // 
            resources.ApplyResources(this.FirstNameInput, "FirstNameInput");
            this.FirstNameInput.Name = "FirstNameInput";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // fullName
            // 
            resources.ApplyResources(this.fullName, "fullName");
            this.fullName.Name = "fullName";
            // 
            // LastNameInput
            // 
            resources.ApplyResources(this.LastNameInput, "LastNameInput");
            this.LastNameInput.Name = "LastNameInput";
            // 
            // firstNameLabel
            // 
            resources.ApplyResources(this.firstNameLabel, "firstNameLabel");
            this.firstNameLabel.Name = "firstNameLabel";
            // 
            // lastNameLabel
            // 
            resources.ApplyResources(this.lastNameLabel, "lastNameLabel");
            this.lastNameLabel.Name = "lastNameLabel";
            // 
            // AddQuote
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.LastNameInput);
            this.Controls.Add(this.RushDaysInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SurfaceMaterialInput);
            this.Controls.Add(this.NumDrawersInput);
            this.Controls.Add(this.DeskDepthInput);
            this.Controls.Add(this.DeskWidthInput);
            this.Controls.Add(this.FirstNameInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fullName);
            this.Name = "AddQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox RushDaysInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SurfaceMaterialInput;
        private System.Windows.Forms.TextBox NumDrawersInput;
        private System.Windows.Forms.TextBox DeskDepthInput;
        private System.Windows.Forms.TextBox DeskWidthInput;
        private System.Windows.Forms.TextBox FirstNameInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fullName;
        private System.Windows.Forms.TextBox LastNameInput;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
    }
}