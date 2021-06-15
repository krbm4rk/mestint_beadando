
namespace mestint_beadando
{
    partial class Form1
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
            this.cbKeresok = new System.Windows.Forms.ComboBox();
            this.osszlepes = new System.Windows.Forms.Label();
            this.lepes = new System.Windows.Forms.Label();
            this.pbJatek = new System.Windows.Forms.PictureBox();
            this.hatraBtn = new System.Windows.Forms.Button();
            this.eloreBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbJatek)).BeginInit();
            this.SuspendLayout();
            // 
            // cbKeresok
            // 
            this.cbKeresok.FormattingEnabled = true;
            this.cbKeresok.Location = new System.Drawing.Point(112, 275);
            this.cbKeresok.Name = "cbKeresok";
            this.cbKeresok.Size = new System.Drawing.Size(120, 21);
            this.cbKeresok.TabIndex = 0;
            this.cbKeresok.SelectedIndexChanged += new System.EventHandler(this.cbKeresok_SelectedIndexChanged);
            // 
            // osszlepes
            // 
            this.osszlepes.AutoSize = true;
            this.osszlepes.Location = new System.Drawing.Point(90, 55);
            this.osszlepes.Name = "osszlepes";
            this.osszlepes.Size = new System.Drawing.Size(35, 13);
            this.osszlepes.TabIndex = 1;
            this.osszlepes.Text = "label1";
            // 
            // lepes
            // 
            this.lepes.AutoSize = true;
            this.lepes.Location = new System.Drawing.Point(88, 20);
            this.lepes.Name = "lepes";
            this.lepes.Size = new System.Drawing.Size(35, 13);
            this.lepes.TabIndex = 2;
            this.lepes.Text = "label2";
            // 
            // pbJatek
            // 
            this.pbJatek.Location = new System.Drawing.Point(299, 9);
            this.pbJatek.Name = "pbJatek";
            this.pbJatek.Size = new System.Drawing.Size(296, 381);
            this.pbJatek.TabIndex = 3;
            this.pbJatek.TabStop = false;
            this.pbJatek.Paint += new System.Windows.Forms.PaintEventHandler(this.pbJatek_Paint);
            // 
            // hatraBtn
            // 
            this.hatraBtn.Location = new System.Drawing.Point(15, 325);
            this.hatraBtn.Name = "hatraBtn";
            this.hatraBtn.Size = new System.Drawing.Size(120, 60);
            this.hatraBtn.TabIndex = 4;
            this.hatraBtn.Text = "Hátra";
            this.hatraBtn.UseVisualStyleBackColor = true;
            this.hatraBtn.Click += new System.EventHandler(this.hatraBtn_Click);
            // 
            // eloreBtn
            // 
            this.eloreBtn.Location = new System.Drawing.Point(158, 325);
            this.eloreBtn.Name = "eloreBtn";
            this.eloreBtn.Size = new System.Drawing.Size(120, 60);
            this.eloreBtn.TabIndex = 5;
            this.eloreBtn.Text = "Előre";
            this.eloreBtn.UseVisualStyleBackColor = true;
            this.eloreBtn.Click += new System.EventHandler(this.eloreBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Összes lépés:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lépés:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Keresők:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 397);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eloreBtn);
            this.Controls.Add(this.hatraBtn);
            this.Controls.Add(this.pbJatek);
            this.Controls.Add(this.lepes);
            this.Controls.Add(this.osszlepes);
            this.Controls.Add(this.cbKeresok);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbJatek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKeresok;
        private System.Windows.Forms.Label osszlepes;
        private System.Windows.Forms.Label lepes;
        private System.Windows.Forms.PictureBox pbJatek;
        private System.Windows.Forms.Button hatraBtn;
        private System.Windows.Forms.Button eloreBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

