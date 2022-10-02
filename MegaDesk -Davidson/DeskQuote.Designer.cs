namespace MegaDesk__Davidson
{
    partial class DeskQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeskQuote));
            this.newQuote = new System.Windows.Forms.Button();
            this.viewQuote = new System.Windows.Forms.Button();
            this.searchQuotes = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // newQuote
            // 
            this.newQuote.Location = new System.Drawing.Point(71, 50);
            this.newQuote.Name = "newQuote";
            this.newQuote.Size = new System.Drawing.Size(163, 51);
            this.newQuote.TabIndex = 0;
            this.newQuote.Text = "Add New Quote";
            this.newQuote.UseVisualStyleBackColor = true;
            // 
            // viewQuote
            // 
            this.viewQuote.Location = new System.Drawing.Point(71, 127);
            this.viewQuote.Name = "viewQuote";
            this.viewQuote.Size = new System.Drawing.Size(163, 51);
            this.viewQuote.TabIndex = 1;
            this.viewQuote.Text = "View Quotes";
            this.viewQuote.UseVisualStyleBackColor = true;
            this.viewQuote.Click += new System.EventHandler(this.button2_Click);
            // 
            // searchQuotes
            // 
            this.searchQuotes.Location = new System.Drawing.Point(71, 213);
            this.searchQuotes.Name = "searchQuotes";
            this.searchQuotes.Size = new System.Drawing.Size(163, 51);
            this.searchQuotes.TabIndex = 2;
            this.searchQuotes.Text = "Search Quotes";
            this.searchQuotes.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(71, 299);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(163, 51);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(364, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 299);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // DeskQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.searchQuotes);
            this.Controls.Add(this.viewQuote);
            this.Controls.Add(this.newQuote);
            this.Name = "DeskQuote";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newQuote;
        private System.Windows.Forms.Button viewQuote;
        private System.Windows.Forms.Button searchQuotes;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}