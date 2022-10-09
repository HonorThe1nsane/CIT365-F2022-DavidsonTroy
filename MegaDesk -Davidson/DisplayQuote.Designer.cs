using System.Drawing;

namespace MegaDesk__Davidson
{
    partial class DisplayQuote
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
            this.closeQuote = new System.Windows.Forms.Button();
            this.QuoteSummaryLabel = new System.Windows.Forms.Label();
            this.fullNamelbl = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.numDrawLabel = new System.Windows.Forms.Label();
            this.materialLabel = new System.Windows.Forms.Label();
            this.rushLabel = new System.Windows.Forms.Label();
            this.quoteTotalLabel = new System.Windows.Forms.Label();
            this.dateQuote = new System.Windows.Forms.Label();
            this.customerNameQuote = new System.Windows.Forms.TextBox();
            this.widthQuote = new System.Windows.Forms.TextBox();
            this.depthQuote = new System.Windows.Forms.TextBox();
            this.drawersQuote = new System.Windows.Forms.TextBox();
            this.materialQuote = new System.Windows.Forms.TextBox();
            this.rushQuote = new System.Windows.Forms.TextBox();
            this.totalQuote = new System.Windows.Forms.TextBox();
            this.dateForQuote = new System.Windows.Forms.TextBox();
            this.deskQuoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deskBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.deskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deskQuoteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.saveOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // closeQuote
            // 
            this.closeQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeQuote.Location = new System.Drawing.Point(678, 403);
            this.closeQuote.Name = "closeQuote";
            this.closeQuote.Size = new System.Drawing.Size(110, 35);
            this.closeQuote.TabIndex = 1;
            this.closeQuote.Text = "Close Order";
            this.closeQuote.UseVisualStyleBackColor = true;
            this.closeQuote.Click += new System.EventHandler(this.closeQuote_Click);
            // 
            // QuoteSummaryLabel
            // 
            this.QuoteSummaryLabel.AutoSize = true;
            this.QuoteSummaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteSummaryLabel.Location = new System.Drawing.Point(287, 9);
            this.QuoteSummaryLabel.Name = "QuoteSummaryLabel";
            this.QuoteSummaryLabel.Size = new System.Drawing.Size(216, 24);
            this.QuoteSummaryLabel.TabIndex = 10;
            this.QuoteSummaryLabel.Text = "Your Quote Summary:";
            // 
            // fullNamelbl
            // 
            this.fullNamelbl.AutoSize = true;
            this.fullNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNamelbl.Location = new System.Drawing.Point(169, 102);
            this.fullNamelbl.Name = "fullNamelbl";
            this.fullNamelbl.Size = new System.Drawing.Size(81, 16);
            this.fullNamelbl.TabIndex = 11;
            this.fullNamelbl.Text = "Full Name:";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(192, 148);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(50, 16);
            this.widthLabel.TabIndex = 12;
            this.widthLabel.Text = "Width:";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(191, 199);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(52, 16);
            this.depthLabel.TabIndex = 13;
            this.depthLabel.Text = "Depth:";
            // 
            // numDrawLabel
            // 
            this.numDrawLabel.AutoSize = true;
            this.numDrawLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDrawLabel.Location = new System.Drawing.Point(179, 248);
            this.numDrawLabel.Name = "numDrawLabel";
            this.numDrawLabel.Size = new System.Drawing.Size(68, 16);
            this.numDrawLabel.TabIndex = 14;
            this.numDrawLabel.Text = "Drawers:";
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel.Location = new System.Drawing.Point(180, 298);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(67, 16);
            this.materialLabel.TabIndex = 15;
            this.materialLabel.Text = "Material:";
            // 
            // rushLabel
            // 
            this.rushLabel.AutoSize = true;
            this.rushLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushLabel.Location = new System.Drawing.Point(197, 344);
            this.rushLabel.Name = "rushLabel";
            this.rushLabel.Size = new System.Drawing.Size(46, 16);
            this.rushLabel.TabIndex = 16;
            this.rushLabel.Text = "Rush:";
            // 
            // quoteTotalLabel
            // 
            this.quoteTotalLabel.AutoSize = true;
            this.quoteTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteTotalLabel.Location = new System.Drawing.Point(187, 388);
            this.quoteTotalLabel.Name = "quoteTotalLabel";
            this.quoteTotalLabel.Size = new System.Drawing.Size(47, 16);
            this.quoteTotalLabel.TabIndex = 17;
            this.quoteTotalLabel.Text = "Total:";
            // 
            // dateQuote
            // 
            this.dateQuote.AutoSize = true;
            this.dateQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateQuote.Location = new System.Drawing.Point(196, 68);
            this.dateQuote.Name = "dateQuote";
            this.dateQuote.Size = new System.Drawing.Size(44, 16);
            this.dateQuote.TabIndex = 19;
            this.dateQuote.Text = "Date:";
            // 
            // customerNameQuote
            // 
            this.customerNameQuote.BackColor = System.Drawing.SystemColors.Info;
            this.customerNameQuote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerNameQuote.Enabled = false;
            this.customerNameQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameQuote.Location = new System.Drawing.Point(291, 103);
            this.customerNameQuote.Name = "customerNameQuote";
            this.customerNameQuote.Size = new System.Drawing.Size(110, 13);
            this.customerNameQuote.TabIndex = 28;
            this.customerNameQuote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.customerNameQuote.TextChanged += new System.EventHandler(this.customerNameQuote_TextChanged);
            // 
            // widthQuote
            // 
            this.widthQuote.BackColor = System.Drawing.SystemColors.Info;
            this.widthQuote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.widthQuote.Enabled = false;
            this.widthQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthQuote.Location = new System.Drawing.Point(291, 149);
            this.widthQuote.Name = "widthQuote";
            this.widthQuote.Size = new System.Drawing.Size(110, 13);
            this.widthQuote.TabIndex = 29;
            this.widthQuote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // depthQuote
            // 
            this.depthQuote.BackColor = System.Drawing.SystemColors.Info;
            this.depthQuote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.depthQuote.Enabled = false;
            this.depthQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthQuote.Location = new System.Drawing.Point(291, 200);
            this.depthQuote.Name = "depthQuote";
            this.depthQuote.Size = new System.Drawing.Size(110, 13);
            this.depthQuote.TabIndex = 30;
            this.depthQuote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // drawersQuote
            // 
            this.drawersQuote.BackColor = System.Drawing.SystemColors.Info;
            this.drawersQuote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.drawersQuote.Enabled = false;
            this.drawersQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawersQuote.Location = new System.Drawing.Point(291, 249);
            this.drawersQuote.Name = "drawersQuote";
            this.drawersQuote.Size = new System.Drawing.Size(110, 13);
            this.drawersQuote.TabIndex = 31;
            this.drawersQuote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // materialQuote
            // 
            this.materialQuote.BackColor = System.Drawing.SystemColors.Info;
            this.materialQuote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialQuote.Enabled = false;
            this.materialQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialQuote.Location = new System.Drawing.Point(291, 299);
            this.materialQuote.Name = "materialQuote";
            this.materialQuote.Size = new System.Drawing.Size(110, 13);
            this.materialQuote.TabIndex = 32;
            this.materialQuote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rushQuote
            // 
            this.rushQuote.BackColor = System.Drawing.SystemColors.Info;
            this.rushQuote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rushQuote.Enabled = false;
            this.rushQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushQuote.Location = new System.Drawing.Point(292, 345);
            this.rushQuote.Name = "rushQuote";
            this.rushQuote.Size = new System.Drawing.Size(110, 13);
            this.rushQuote.TabIndex = 33;
            this.rushQuote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalQuote
            // 
            this.totalQuote.BackColor = System.Drawing.SystemColors.Info;
            this.totalQuote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalQuote.Enabled = false;
            this.totalQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalQuote.Location = new System.Drawing.Point(291, 390);
            this.totalQuote.Name = "totalQuote";
            this.totalQuote.Size = new System.Drawing.Size(110, 13);
            this.totalQuote.TabIndex = 34;
            this.totalQuote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateForQuote
            // 
            this.dateForQuote.BackColor = System.Drawing.SystemColors.Info;
            this.dateForQuote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateForQuote.Enabled = false;
            this.dateForQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateForQuote.Location = new System.Drawing.Point(291, 71);
            this.dateForQuote.Name = "dateForQuote";
            this.dateForQuote.Size = new System.Drawing.Size(110, 13);
            this.dateForQuote.TabIndex = 35;
            this.dateForQuote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // deskQuoteBindingSource
            // 
            this.deskQuoteBindingSource.DataSource = typeof(MegaDesk__Davidson.DeskQuote);
            // 
            // deskBindingSource1
            // 
            this.deskBindingSource1.DataSource = typeof(MegaDesk__Davidson.Desk);
            // 
            // deskBindingSource
            // 
            this.deskBindingSource.DataSource = typeof(MegaDesk__Davidson.Desk);
            // 
            // deskQuoteBindingSource1
            // 
            this.deskQuoteBindingSource1.DataSource = typeof(MegaDesk__Davidson.DeskQuote);
            // 
            // saveOrder
            // 
            this.saveOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveOrder.Location = new System.Drawing.Point(562, 403);
            this.saveOrder.Name = "saveOrder";
            this.saveOrder.Size = new System.Drawing.Size(110, 35);
            this.saveOrder.TabIndex = 36;
            this.saveOrder.Text = "Save Order";
            this.saveOrder.UseVisualStyleBackColor = true;
            this.saveOrder.Click += new System.EventHandler(this.saveOrder_Click);
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveOrder);
            this.Controls.Add(this.dateForQuote);
            this.Controls.Add(this.totalQuote);
            this.Controls.Add(this.rushQuote);
            this.Controls.Add(this.materialQuote);
            this.Controls.Add(this.drawersQuote);
            this.Controls.Add(this.depthQuote);
            this.Controls.Add(this.widthQuote);
            this.Controls.Add(this.customerNameQuote);
            this.Controls.Add(this.dateQuote);
            this.Controls.Add(this.quoteTotalLabel);
            this.Controls.Add(this.rushLabel);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.numDrawLabel);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.fullNamelbl);
            this.Controls.Add(this.QuoteSummaryLabel);
            this.Controls.Add(this.closeQuote);
            this.Name = "DisplayQuote";
            this.Text = "Display Quote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DisplayQuote_FormClosed);
            this.Load += new System.EventHandler(this.DisplayQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closeQuote;
        private System.Windows.Forms.Label QuoteSummaryLabel;
        private System.Windows.Forms.Label fullNamelbl;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label numDrawLabel;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.Label rushLabel;
        private System.Windows.Forms.Label quoteTotalLabel;
        private System.Windows.Forms.Label dateQuote;
        private System.Windows.Forms.BindingSource deskQuoteBindingSource;
        private System.Windows.Forms.BindingSource deskBindingSource1;
        private System.Windows.Forms.BindingSource deskBindingSource;
        private System.Windows.Forms.BindingSource deskQuoteBindingSource1;
        public System.Windows.Forms.TextBox customerNameQuote;
        public System.Windows.Forms.TextBox widthQuote;
        public System.Windows.Forms.TextBox depthQuote;
        public System.Windows.Forms.TextBox drawersQuote;
        public System.Windows.Forms.TextBox materialQuote;
        public System.Windows.Forms.TextBox rushQuote;
        public System.Windows.Forms.TextBox totalQuote;
        public System.Windows.Forms.TextBox dateForQuote;
        private System.Windows.Forms.Button saveOrder;
    }
}