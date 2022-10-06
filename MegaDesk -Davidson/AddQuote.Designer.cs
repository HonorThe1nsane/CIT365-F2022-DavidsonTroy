namespace MegaDesk__Davidson
{
    public partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            this.label6 = new System.Windows.Forms.Label();
            this.NumDrawersInput = new System.Windows.Forms.TextBox();
            this.DeskDepthInput = new System.Windows.Forms.TextBox();
            this.DeskWidthInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fullName = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SelectedMaterial = new System.Windows.Forms.ComboBox();
            this.ShipRushDays = new System.Windows.Forms.ComboBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.errorCname = new System.Windows.Forms.ErrorProvider(this.components);
            this.customerNameInput = new System.Windows.Forms.TextBox();
            this.errorWDesk = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDDesk = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNumDrawers = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSurfMat = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorRushDays = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorCname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorWDesk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDDesk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNumDrawers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSurfMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRushDays)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // NumDrawersInput
            // 
            resources.ApplyResources(this.NumDrawersInput, "NumDrawersInput");
            this.NumDrawersInput.Name = "NumDrawersInput";
            this.NumDrawersInput.Validating += new System.ComponentModel.CancelEventHandler(this.NumDrawersInput_Validating);
            // 
            // DeskDepthInput
            // 
            resources.ApplyResources(this.DeskDepthInput, "DeskDepthInput");
            this.DeskDepthInput.Name = "DeskDepthInput";
            this.DeskDepthInput.Validating += new System.ComponentModel.CancelEventHandler(this.DeskDepthInput_Validating);
            // 
            // DeskWidthInput
            // 
            resources.ApplyResources(this.DeskWidthInput, "DeskWidthInput");
            this.DeskWidthInput.Name = "DeskWidthInput";
            this.DeskWidthInput.Validating += new System.ComponentModel.CancelEventHandler(this.DeskWidthInput_Validating);
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
            // cancelBtn
            // 
            resources.ApplyResources(this.cancelBtn, "cancelBtn");
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click_1);
            // 
            // SelectedMaterial
            // 
            this.SelectedMaterial.FormattingEnabled = true;
            resources.ApplyResources(this.SelectedMaterial, "SelectedMaterial");
            this.SelectedMaterial.Name = "SelectedMaterial";
            this.SelectedMaterial.Validating += new System.ComponentModel.CancelEventHandler(this.selectedMaterial_Validating);
            // 
            // ShipRushDays
            // 
            this.ShipRushDays.FormattingEnabled = true;
            resources.ApplyResources(this.ShipRushDays, "ShipRushDays");
            this.ShipRushDays.Name = "ShipRushDays";
            this.ShipRushDays.Validating += new System.ComponentModel.CancelEventHandler(this.shipRushDays_Validating);
            // 
            // submitBtn
            // 
            resources.ApplyResources(this.submitBtn, "submitBtn");
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // errorCname
            // 
            this.errorCname.ContainerControl = this;
            // 
            // customerNameInput
            // 
            resources.ApplyResources(this.customerNameInput, "customerNameInput");
            this.customerNameInput.Name = "customerNameInput";
            this.customerNameInput.Validating += new System.ComponentModel.CancelEventHandler(this.FirstNameInput_Validating);
            // 
            // errorWDesk
            // 
            this.errorWDesk.ContainerControl = this;
            // 
            // errorDDesk
            // 
            this.errorDDesk.ContainerControl = this;
            // 
            // errorNumDrawers
            // 
            this.errorNumDrawers.ContainerControl = this;
            // 
            // errorSurfMat
            // 
            this.errorSurfMat.ContainerControl = this;
            // 
            // errorRushDays
            // 
            this.errorRushDays.ContainerControl = this;
            // 
            // AddQuote
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customerNameInput);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.ShipRushDays);
            this.Controls.Add(this.SelectedMaterial);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NumDrawersInput);
            this.Controls.Add(this.DeskDepthInput);
            this.Controls.Add(this.DeskWidthInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fullName);
            this.Name = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.errorCname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorWDesk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDDesk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNumDrawers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSurfMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRushDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NumDrawersInput;
        private System.Windows.Forms.TextBox DeskDepthInput;
        private System.Windows.Forms.TextBox DeskWidthInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fullName;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ComboBox SelectedMaterial;
        private System.Windows.Forms.ComboBox ShipRushDays;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.ErrorProvider errorCname;
        private System.Windows.Forms.TextBox customerNameInput;
        private System.Windows.Forms.ErrorProvider errorWDesk;
        private System.Windows.Forms.ErrorProvider errorDDesk;
        private System.Windows.Forms.ErrorProvider errorNumDrawers;
        private System.Windows.Forms.ErrorProvider errorSurfMat;
        private System.Windows.Forms.ErrorProvider errorRushDays;
    }
}