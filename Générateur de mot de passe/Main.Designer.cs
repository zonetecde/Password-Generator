namespace Générateur_de_mot_de_passe
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_title = new System.Windows.Forms.Label();
            this.panel_contientLeLabelMDP = new System.Windows.Forms.Panel();
            this.textBox_modifyPass = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.button_generate = new System.Windows.Forms.Button();
            this.button_parameter = new System.Windows.Forms.Button();
            this.button_copy = new System.Windows.Forms.Button();
            this.button_memoriser = new System.Windows.Forms.Button();
            this.panel_contientLeLabelMDP.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(17, 11);
            this.label_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(813, 48);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Mot de passe généré :";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_contientLeLabelMDP
            // 
            this.panel_contientLeLabelMDP.BackColor = System.Drawing.Color.Black;
            this.panel_contientLeLabelMDP.Controls.Add(this.textBox_modifyPass);
            this.panel_contientLeLabelMDP.Controls.Add(this.label_password);
            this.panel_contientLeLabelMDP.Location = new System.Drawing.Point(24, 64);
            this.panel_contientLeLabelMDP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_contientLeLabelMDP.Name = "panel_contientLeLabelMDP";
            this.panel_contientLeLabelMDP.Size = new System.Drawing.Size(807, 94);
            this.panel_contientLeLabelMDP.TabIndex = 2;
            // 
            // textBox_modifyPass
            // 
            this.textBox_modifyPass.BackColor = System.Drawing.Color.Black;
            this.textBox_modifyPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_modifyPass.Font = new System.Drawing.Font("Consolas", 26.25F);
            this.textBox_modifyPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBox_modifyPass.Location = new System.Drawing.Point(5, 22);
            this.textBox_modifyPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_modifyPass.Name = "textBox_modifyPass";
            this.textBox_modifyPass.Size = new System.Drawing.Size(799, 52);
            this.textBox_modifyPass.TabIndex = 1;
            this.textBox_modifyPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_modifyPass.Visible = false;
            this.textBox_modifyPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_modifyPass_KeyDown);
            // 
            // label_password
            // 
            this.label_password.BackColor = System.Drawing.Color.Black;
            this.label_password.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label_password.Location = new System.Drawing.Point(4, 0);
            this.label_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(803, 94);
            this.label_password.TabIndex = 0;
            this.label_password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_password.DoubleClick += new System.EventHandler(this.label_password_DoubleClick);
            // 
            // button_generate
            // 
            this.button_generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.button_generate.Location = new System.Drawing.Point(235, 181);
            this.button_generate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(172, 28);
            this.button_generate.TabIndex = 3;
            this.button_generate.Text = "Générer";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // button_parameter
            // 
            this.button_parameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.button_parameter.Location = new System.Drawing.Point(24, 181);
            this.button_parameter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_parameter.Name = "button_parameter";
            this.button_parameter.Size = new System.Drawing.Size(172, 28);
            this.button_parameter.TabIndex = 4;
            this.button_parameter.Text = "Paramètres";
            this.button_parameter.UseVisualStyleBackColor = true;
            this.button_parameter.Click += new System.EventHandler(this.button_parameter_Click);
            // 
            // button_copy
            // 
            this.button_copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.button_copy.Location = new System.Drawing.Point(441, 181);
            this.button_copy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(172, 28);
            this.button_copy.TabIndex = 5;
            this.button_copy.Text = "Copier";
            this.button_copy.UseVisualStyleBackColor = true;
            this.button_copy.Click += new System.EventHandler(this.button_copy_Click);
            // 
            // button_memoriser
            // 
            this.button_memoriser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.button_memoriser.Location = new System.Drawing.Point(656, 181);
            this.button_memoriser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_memoriser.Name = "button_memoriser";
            this.button_memoriser.Size = new System.Drawing.Size(172, 28);
            this.button_memoriser.TabIndex = 6;
            this.button_memoriser.Text = "Mémoriser";
            this.button_memoriser.UseVisualStyleBackColor = true;
            this.button_memoriser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_memoriser_MouseDown);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(847, 219);
            this.Controls.Add(this.button_memoriser);
            this.Controls.Add(this.button_copy);
            this.Controls.Add(this.button_parameter);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.panel_contientLeLabelMDP);
            this.Controls.Add(this.label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Générateur de mot de passe";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel_contientLeLabelMDP.ResumeLayout(false);
            this.panel_contientLeLabelMDP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Panel panel_contientLeLabelMDP;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.Button button_parameter;
        private System.Windows.Forms.Button button_copy;
        private System.Windows.Forms.TextBox textBox_modifyPass;
        private System.Windows.Forms.Button button_memoriser;
    }
}

