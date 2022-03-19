namespace Générateur_de_mot_de_passe
{
    partial class UserControl_Lettre
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_lettre = new System.Windows.Forms.Label();
            this.panel_words = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label_lettre
            // 
            this.label_lettre.Font = new System.Drawing.Font("Corbel", 35.25F, System.Drawing.FontStyle.Bold);
            this.label_lettre.Location = new System.Drawing.Point(4, 0);
            this.label_lettre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_lettre.Name = "label_lettre";
            this.label_lettre.Size = new System.Drawing.Size(168, 75);
            this.label_lettre.TabIndex = 0;
            this.label_lettre.Text = "&";
            this.label_lettre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_lettre.UseMnemonic = false;
            // 
            // panel_words
            // 
            this.panel_words.AutoScroll = true;
            this.panel_words.Location = new System.Drawing.Point(0, 79);
            this.panel_words.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_words.Name = "panel_words";
            this.panel_words.Size = new System.Drawing.Size(192, 342);
            this.panel_words.TabIndex = 1;
            this.panel_words.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panel_words_Scroll);
            this.panel_words.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_words_Paint);
            // 
            // UserControl_Lettre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_words);
            this.Controls.Add(this.label_lettre);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControl_Lettre";
            this.Size = new System.Drawing.Size(176, 421);
            this.Load += new System.EventHandler(this.UserControl_Lettre_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_lettre;
        private System.Windows.Forms.Panel panel_words;
    }
}
