namespace Waluty
{
    partial class GlowneOkno
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
            this.btnKonwertuj = new System.Windows.Forms.Button();
            this.lblWynik = new System.Windows.Forms.Label();
            this.tbPLN = new System.Windows.Forms.TextBox();
            this.cbWalutaDo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbNotowania = new System.Windows.Forms.ComboBox();
            this.lblWczytywanie = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbWalutaZ = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnKonwertuj
            // 
            this.btnKonwertuj.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnKonwertuj.Location = new System.Drawing.Point(15, 166);
            this.btnKonwertuj.Name = "btnKonwertuj";
            this.btnKonwertuj.Size = new System.Drawing.Size(134, 23);
            this.btnKonwertuj.TabIndex = 0;
            this.btnKonwertuj.Text = "Konwertuj ";
            this.btnKonwertuj.UseVisualStyleBackColor = true;
            this.btnKonwertuj.Click += new System.EventHandler(this.btnKonwertuj_Click);
            // 
            // lblWynik
            // 
            this.lblWynik.AutoSize = true;
            this.lblWynik.Location = new System.Drawing.Point(155, 143);
            this.lblWynik.Name = "lblWynik";
            this.lblWynik.Size = new System.Drawing.Size(13, 13);
            this.lblWynik.TabIndex = 2;
            this.lblWynik.Text = "0";
            // 
            // tbPLN
            // 
            this.tbPLN.Location = new System.Drawing.Point(15, 140);
            this.tbPLN.Name = "tbPLN";
            this.tbPLN.Size = new System.Drawing.Size(134, 20);
            this.tbPLN.TabIndex = 3;
            // 
            // cbWalutaDo
            // 
            this.cbWalutaDo.FormattingEnabled = true;
            this.cbWalutaDo.Location = new System.Drawing.Point(157, 100);
            this.cbWalutaDo.Name = "cbWalutaDo";
            this.cbWalutaDo.Size = new System.Drawing.Size(136, 21);
            this.cbWalutaDo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Konwertuj do:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Podaj kwote:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Notowanie:";
            // 
            // cbNotowania
            // 
            this.cbNotowania.FormattingEnabled = true;
            this.cbNotowania.Location = new System.Drawing.Point(15, 30);
            this.cbNotowania.Name = "cbNotowania";
            this.cbNotowania.Size = new System.Drawing.Size(136, 21);
            this.cbNotowania.TabIndex = 10;
            this.cbNotowania.SelectedIndexChanged += new System.EventHandler(this.cbNotowania_SelectedIndexChanged);
            // 
            // lblWczytywanie
            // 
            this.lblWczytywanie.AutoSize = true;
            this.lblWczytywanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWczytywanie.Location = new System.Drawing.Point(195, 9);
            this.lblWczytywanie.Name = "lblWczytywanie";
            this.lblWczytywanie.Size = new System.Drawing.Size(181, 13);
            this.lblWczytywanie.TabIndex = 11;
            this.lblWczytywanie.Text = "Wczytywanie danych z NBP....";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Konwertuj z:";
            // 
            // cbWalutaZ
            // 
            this.cbWalutaZ.FormattingEnabled = true;
            this.cbWalutaZ.Location = new System.Drawing.Point(15, 100);
            this.cbWalutaZ.Name = "cbWalutaZ";
            this.cbWalutaZ.Size = new System.Drawing.Size(136, 21);
            this.cbWalutaZ.TabIndex = 13;
            // 
            // GlowneOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 337);
            this.Controls.Add(this.cbWalutaZ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWczytywanie);
            this.Controls.Add(this.cbNotowania);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbWalutaDo);
            this.Controls.Add(this.tbPLN);
            this.Controls.Add(this.lblWynik);
            this.Controls.Add(this.btnKonwertuj);
            this.Name = "GlowneOkno";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKonwertuj;
        private System.Windows.Forms.Label lblWynik;
        private System.Windows.Forms.TextBox tbPLN;
        private System.Windows.Forms.ComboBox cbWalutaDo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbNotowania;
        private System.Windows.Forms.Label lblWczytywanie;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbWalutaZ;
    }
}

