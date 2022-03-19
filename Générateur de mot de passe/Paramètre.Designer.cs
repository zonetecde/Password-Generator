namespace Générateur_de_mot_de_passe
{
    partial class Paramètres
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
            this.label_title = new System.Windows.Forms.Label();
            this.checkBox_majusculeAutoriser = new System.Windows.Forms.CheckBox();
            this.checkBox_lettresAutoriser = new System.Windows.Forms.CheckBox();
            this.checkBox_chiffresAutoriser = new System.Windows.Forms.CheckBox();
            this.checkBox_caracteresSpeciauxAutoriser = new System.Windows.Forms.CheckBox();
            this.label_title_caracteresBannis = new System.Windows.Forms.Label();
            this.textBox_caracteresBannis = new System.Windows.Forms.TextBox();
            this.label_indication_caracteresBannis = new System.Windows.Forms.Label();
            this.trackBar_passwordLength = new System.Windows.Forms.TrackBar();
            this.label_title_passwordLength = new System.Windows.Forms.Label();
            this.button_saveAndQuit = new System.Windows.Forms.Button();
            this.panel_caracteresBannisIsCorrect = new System.Windows.Forms.Panel();
            this.checkBox_autoriserAccent = new System.Windows.Forms.CheckBox();
            this.label_passwordLength = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_passwordLength)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(12, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(407, 39);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "Paramètres :";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox_majusculeAutoriser
            // 
            this.checkBox_majusculeAutoriser.AutoSize = true;
            this.checkBox_majusculeAutoriser.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_majusculeAutoriser.Checked = true;
            this.checkBox_majusculeAutoriser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_majusculeAutoriser.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_majusculeAutoriser.Location = new System.Drawing.Point(17, 66);
            this.checkBox_majusculeAutoriser.Name = "checkBox_majusculeAutoriser";
            this.checkBox_majusculeAutoriser.Size = new System.Drawing.Size(216, 27);
            this.checkBox_majusculeAutoriser.TabIndex = 3;
            this.checkBox_majusculeAutoriser.Text = "Contient des majuscules";
            this.checkBox_majusculeAutoriser.UseVisualStyleBackColor = false;
            this.checkBox_majusculeAutoriser.CheckedChanged += new System.EventHandler(this.checkBox_majusculeAutoriser_CheckedChanged);
            // 
            // checkBox_lettresAutoriser
            // 
            this.checkBox_lettresAutoriser.AutoSize = true;
            this.checkBox_lettresAutoriser.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_lettresAutoriser.Checked = true;
            this.checkBox_lettresAutoriser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_lettresAutoriser.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_lettresAutoriser.Location = new System.Drawing.Point(17, 99);
            this.checkBox_lettresAutoriser.Name = "checkBox_lettresAutoriser";
            this.checkBox_lettresAutoriser.Size = new System.Drawing.Size(179, 27);
            this.checkBox_lettresAutoriser.TabIndex = 4;
            this.checkBox_lettresAutoriser.Text = "Contient des lettres";
            this.checkBox_lettresAutoriser.UseVisualStyleBackColor = false;
            this.checkBox_lettresAutoriser.CheckedChanged += new System.EventHandler(this.checkBox_lettresAutoriser_CheckedChanged);
            // 
            // checkBox_chiffresAutoriser
            // 
            this.checkBox_chiffresAutoriser.AutoSize = true;
            this.checkBox_chiffresAutoriser.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_chiffresAutoriser.Checked = true;
            this.checkBox_chiffresAutoriser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_chiffresAutoriser.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_chiffresAutoriser.Location = new System.Drawing.Point(17, 132);
            this.checkBox_chiffresAutoriser.Name = "checkBox_chiffresAutoriser";
            this.checkBox_chiffresAutoriser.Size = new System.Drawing.Size(187, 27);
            this.checkBox_chiffresAutoriser.TabIndex = 5;
            this.checkBox_chiffresAutoriser.Text = "Contient des chiffres";
            this.checkBox_chiffresAutoriser.UseVisualStyleBackColor = false;
            this.checkBox_chiffresAutoriser.CheckedChanged += new System.EventHandler(this.checkBox_chiffresAutoriser_CheckedChanged);
            // 
            // checkBox_caracteresSpeciauxAutoriser
            // 
            this.checkBox_caracteresSpeciauxAutoriser.AutoSize = true;
            this.checkBox_caracteresSpeciauxAutoriser.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_caracteresSpeciauxAutoriser.Checked = true;
            this.checkBox_caracteresSpeciauxAutoriser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_caracteresSpeciauxAutoriser.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_caracteresSpeciauxAutoriser.Location = new System.Drawing.Point(17, 165);
            this.checkBox_caracteresSpeciauxAutoriser.Name = "checkBox_caracteresSpeciauxAutoriser";
            this.checkBox_caracteresSpeciauxAutoriser.Size = new System.Drawing.Size(280, 27);
            this.checkBox_caracteresSpeciauxAutoriser.TabIndex = 6;
            this.checkBox_caracteresSpeciauxAutoriser.Text = "Contient des caractères spéciaux";
            this.checkBox_caracteresSpeciauxAutoriser.UseVisualStyleBackColor = false;
            this.checkBox_caracteresSpeciauxAutoriser.CheckedChanged += new System.EventHandler(this.checkBox_caracteresSpeciauxAutoriser_CheckedChanged);
            // 
            // label_title_caracteresBannis
            // 
            this.label_title_caracteresBannis.AutoSize = true;
            this.label_title_caracteresBannis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label_title_caracteresBannis.Location = new System.Drawing.Point(13, 303);
            this.label_title_caracteresBannis.Name = "label_title_caracteresBannis";
            this.label_title_caracteresBannis.Size = new System.Drawing.Size(199, 25);
            this.label_title_caracteresBannis.TabIndex = 7;
            this.label_title_caracteresBannis.Text = "Caractères bannis :";
            // 
            // textBox_caracteresBannis
            // 
            this.textBox_caracteresBannis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.textBox_caracteresBannis.Location = new System.Drawing.Point(17, 331);
            this.textBox_caracteresBannis.Name = "textBox_caracteresBannis";
            this.textBox_caracteresBannis.Size = new System.Drawing.Size(402, 27);
            this.textBox_caracteresBannis.TabIndex = 8;
            this.textBox_caracteresBannis.TextChanged += new System.EventHandler(this.textBox_caracteresBannis_TextChanged);
            // 
            // label_indication_caracteresBannis
            // 
            this.label_indication_caracteresBannis.AutoSize = true;
            this.label_indication_caracteresBannis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_indication_caracteresBannis.Location = new System.Drawing.Point(214, 361);
            this.label_indication_caracteresBannis.Name = "label_indication_caracteresBannis";
            this.label_indication_caracteresBannis.Size = new System.Drawing.Size(178, 15);
            this.label_indication_caracteresBannis.TabIndex = 9;
            this.label_indication_caracteresBannis.Text = "Séparé par une virgule (1,2,3...)";
            // 
            // trackBar_passwordLength
            // 
            this.trackBar_passwordLength.LargeChange = 1;
            this.trackBar_passwordLength.Location = new System.Drawing.Point(17, 258);
            this.trackBar_passwordLength.Maximum = 200;
            this.trackBar_passwordLength.Minimum = 4;
            this.trackBar_passwordLength.Name = "trackBar_passwordLength";
            this.trackBar_passwordLength.Size = new System.Drawing.Size(402, 45);
            this.trackBar_passwordLength.TabIndex = 10;
            this.trackBar_passwordLength.Value = 16;
            this.trackBar_passwordLength.Scroll += new System.EventHandler(this.trackBar_passwordLength_Scroll);
            // 
            // label_title_passwordLength
            // 
            this.label_title_passwordLength.AutoSize = true;
            this.label_title_passwordLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label_title_passwordLength.Location = new System.Drawing.Point(13, 232);
            this.label_title_passwordLength.Name = "label_title_passwordLength";
            this.label_title_passwordLength.Size = new System.Drawing.Size(280, 25);
            this.label_title_passwordLength.TabIndex = 11;
            this.label_title_passwordLength.Text = "Longueur de mot de passe :";
            // 
            // button_saveAndQuit
            // 
            this.button_saveAndQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button_saveAndQuit.Location = new System.Drawing.Point(17, 393);
            this.button_saveAndQuit.Name = "button_saveAndQuit";
            this.button_saveAndQuit.Size = new System.Drawing.Size(402, 30);
            this.button_saveAndQuit.TabIndex = 13;
            this.button_saveAndQuit.Text = "Enregistrer et quitter";
            this.button_saveAndQuit.UseVisualStyleBackColor = true;
            this.button_saveAndQuit.Click += new System.EventHandler(this.button_saveAndQuit_Click);
            // 
            // panel_caracteresBannisIsCorrect
            // 
            this.panel_caracteresBannisIsCorrect.BackColor = System.Drawing.Color.Green;
            this.panel_caracteresBannisIsCorrect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_caracteresBannisIsCorrect.Location = new System.Drawing.Point(14, 328);
            this.panel_caracteresBannisIsCorrect.Name = "panel_caracteresBannisIsCorrect";
            this.panel_caracteresBannisIsCorrect.Size = new System.Drawing.Size(407, 33);
            this.panel_caracteresBannisIsCorrect.TabIndex = 14;
            // 
            // checkBox_autoriserAccent
            // 
            this.checkBox_autoriserAccent.AutoSize = true;
            this.checkBox_autoriserAccent.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_autoriserAccent.Checked = true;
            this.checkBox_autoriserAccent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_autoriserAccent.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_autoriserAccent.Location = new System.Drawing.Point(17, 198);
            this.checkBox_autoriserAccent.Name = "checkBox_autoriserAccent";
            this.checkBox_autoriserAccent.Size = new System.Drawing.Size(295, 27);
            this.checkBox_autoriserAccent.TabIndex = 15;
            this.checkBox_autoriserAccent.Text = "Contient des accents sur les lettres";
            this.checkBox_autoriserAccent.UseVisualStyleBackColor = false;
            this.checkBox_autoriserAccent.CheckedChanged += new System.EventHandler(this.checkBox_autoriserAccent_CheckedChanged);
            // 
            // label_passwordLength
            // 
            this.label_passwordLength.AutoSize = true;
            this.label_passwordLength.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_passwordLength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label_passwordLength.Location = new System.Drawing.Point(288, 233);
            this.label_passwordLength.Name = "label_passwordLength";
            this.label_passwordLength.Size = new System.Drawing.Size(34, 23);
            this.label_passwordLength.TabIndex = 17;
            this.label_passwordLength.Text = "15";
            // 
            // Paramètres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(431, 433);
            this.Controls.Add(this.label_passwordLength);
            this.Controls.Add(this.checkBox_autoriserAccent);
            this.Controls.Add(this.button_saveAndQuit);
            this.Controls.Add(this.label_title_passwordLength);
            this.Controls.Add(this.trackBar_passwordLength);
            this.Controls.Add(this.label_indication_caracteresBannis);
            this.Controls.Add(this.textBox_caracteresBannis);
            this.Controls.Add(this.label_title_caracteresBannis);
            this.Controls.Add(this.checkBox_caracteresSpeciauxAutoriser);
            this.Controls.Add(this.checkBox_chiffresAutoriser);
            this.Controls.Add(this.checkBox_lettresAutoriser);
            this.Controls.Add(this.checkBox_majusculeAutoriser);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.panel_caracteresBannisIsCorrect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Paramètres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paramètres";
            this.Load += new System.EventHandler(this.Paramètres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_passwordLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.CheckBox checkBox_majusculeAutoriser;
        private System.Windows.Forms.CheckBox checkBox_lettresAutoriser;
        private System.Windows.Forms.CheckBox checkBox_chiffresAutoriser;
        private System.Windows.Forms.CheckBox checkBox_caracteresSpeciauxAutoriser;
        private System.Windows.Forms.Label label_title_caracteresBannis;
        private System.Windows.Forms.TextBox textBox_caracteresBannis;
        private System.Windows.Forms.Label label_indication_caracteresBannis;
        private System.Windows.Forms.TrackBar trackBar_passwordLength;
        private System.Windows.Forms.Label label_title_passwordLength;
        private System.Windows.Forms.Button button_saveAndQuit;
        private System.Windows.Forms.Panel panel_caracteresBannisIsCorrect;
        private System.Windows.Forms.CheckBox checkBox_autoriserAccent;
        private System.Windows.Forms.Label label_passwordLength;
    }
}