namespace _1sa_2se_Franzelin_Patrick
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Markelbl = new System.Windows.Forms.TextBox();
            this.Verbrauchlbl = new System.Windows.Forms.TextBox();
            this.tankgrößelbl = new System.Windows.Forms.TextBox();
            this.tankenlbl = new System.Windows.Forms.TextBox();
            this.fahrenlbl = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.fahrenbtn = new System.Windows.Forms.Button();
            this.autobtn = new System.Windows.Forms.Button();
            this.tankenbtn = new System.Windows.Forms.Button();
            this.farbebox = new System.Windows.Forms.ComboBox();
            this.TextBox1 = new System.Windows.Forms.RichTextBox();
            this.pslbl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Markelbl
            // 
            this.Markelbl.Location = new System.Drawing.Point(65, 39);
            this.Markelbl.Name = "Markelbl";
            this.Markelbl.Size = new System.Drawing.Size(100, 20);
            this.Markelbl.TabIndex = 0;
            // 
            // Verbrauchlbl
            // 
            this.Verbrauchlbl.Location = new System.Drawing.Point(327, 81);
            this.Verbrauchlbl.Name = "Verbrauchlbl";
            this.Verbrauchlbl.Size = new System.Drawing.Size(100, 20);
            this.Verbrauchlbl.TabIndex = 1;
            // 
            // tankgrößelbl
            // 
            this.tankgrößelbl.Location = new System.Drawing.Point(327, 39);
            this.tankgrößelbl.Name = "tankgrößelbl";
            this.tankgrößelbl.Size = new System.Drawing.Size(100, 20);
            this.tankgrößelbl.TabIndex = 2;
            // 
            // tankenlbl
            // 
            this.tankenlbl.Location = new System.Drawing.Point(12, 212);
            this.tankenlbl.Name = "tankenlbl";
            this.tankenlbl.Size = new System.Drawing.Size(100, 20);
            this.tankenlbl.TabIndex = 3;
            // 
            // fahrenlbl
            // 
            this.fahrenlbl.Location = new System.Drawing.Point(12, 299);
            this.fahrenlbl.Name = "fahrenlbl";
            this.fahrenlbl.Size = new System.Drawing.Size(100, 20);
            this.fahrenlbl.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 248);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(214, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // fahrenbtn
            // 
            this.fahrenbtn.Location = new System.Drawing.Point(130, 299);
            this.fahrenbtn.Name = "fahrenbtn";
            this.fahrenbtn.Size = new System.Drawing.Size(75, 23);
            this.fahrenbtn.TabIndex = 6;
            this.fahrenbtn.Text = "fahren";
            this.fahrenbtn.UseVisualStyleBackColor = true;
            this.fahrenbtn.Click += new System.EventHandler(this.fahrenbtn_Click);
            // 
            // autobtn
            // 
            this.autobtn.Location = new System.Drawing.Point(298, 129);
            this.autobtn.Name = "autobtn";
            this.autobtn.Size = new System.Drawing.Size(144, 23);
            this.autobtn.TabIndex = 7;
            this.autobtn.Text = "auto erstellen";
            this.autobtn.UseVisualStyleBackColor = true;
            this.autobtn.Click += new System.EventHandler(this.autobtn_Click);
            // 
            // tankenbtn
            // 
            this.tankenbtn.Location = new System.Drawing.Point(151, 209);
            this.tankenbtn.Name = "tankenbtn";
            this.tankenbtn.Size = new System.Drawing.Size(75, 23);
            this.tankenbtn.TabIndex = 8;
            this.tankenbtn.Text = "tanken";
            this.tankenbtn.UseVisualStyleBackColor = true;
            this.tankenbtn.Click += new System.EventHandler(this.tankenbtn_Click);
            // 
            // farbebox
            // 
            this.farbebox.FormattingEnabled = true;
            this.farbebox.Items.AddRange(new object[] {
            "rot",
            "gelb",
            "blau",
            "schwarz",
            "weis"});
            this.farbebox.Location = new System.Drawing.Point(50, 80);
            this.farbebox.Name = "farbebox";
            this.farbebox.Size = new System.Drawing.Size(131, 21);
            this.farbebox.TabIndex = 9;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(265, 192);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(188, 181);
            this.TextBox1.TabIndex = 12;
            this.TextBox1.Text = "";
            // 
            // pslbl
            // 
            this.pslbl.Location = new System.Drawing.Point(34, 129);
            this.pslbl.Name = "pslbl";
            this.pslbl.Size = new System.Drawing.Size(147, 20);
            this.pslbl.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 399);
            this.Controls.Add(this.pslbl);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.farbebox);
            this.Controls.Add(this.tankenbtn);
            this.Controls.Add(this.autobtn);
            this.Controls.Add(this.fahrenbtn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.fahrenlbl);
            this.Controls.Add(this.tankenlbl);
            this.Controls.Add(this.tankgrößelbl);
            this.Controls.Add(this.Verbrauchlbl);
            this.Controls.Add(this.Markelbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Markelbl;
        private System.Windows.Forms.TextBox Verbrauchlbl;
        private System.Windows.Forms.TextBox tankgrößelbl;
        private System.Windows.Forms.TextBox tankenlbl;
        private System.Windows.Forms.TextBox fahrenlbl;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button fahrenbtn;
        private System.Windows.Forms.Button autobtn;
        private System.Windows.Forms.Button tankenbtn;
        private System.Windows.Forms.ComboBox farbebox;
        private System.Windows.Forms.RichTextBox TextBox1;
        private System.Windows.Forms.TextBox pslbl;
    }
}

