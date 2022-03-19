namespace Générateur_de_mot_de_passe
{
    partial class Mémoriser
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
            this.menuStrip_option = new System.Windows.Forms.MenuStrip();
            this.aléatoireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phraseAléatoireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_phrase = new System.Windows.Forms.RichTextBox();
            this.panel_letters = new System.Windows.Forms.Panel();
            this.menuStrip_option.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_option
            // 
            this.menuStrip_option.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip_option.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_option.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aléatoireToolStripMenuItem});
            this.menuStrip_option.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_option.Name = "menuStrip_option";
            this.menuStrip_option.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip_option.Size = new System.Drawing.Size(694, 24);
            this.menuStrip_option.TabIndex = 1;
            this.menuStrip_option.Text = "menuStrip1";
            // 
            // aléatoireToolStripMenuItem
            // 
            this.aléatoireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phraseAléatoireToolStripMenuItem});
            this.aléatoireToolStripMenuItem.Name = "aléatoireToolStripMenuItem";
            this.aléatoireToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.aléatoireToolStripMenuItem.Text = "Aléatoire";
            // 
            // phraseAléatoireToolStripMenuItem
            // 
            this.phraseAléatoireToolStripMenuItem.Image = global::Générateur_de_mot_de_passe.Properties.Resources.aleatory_png;
            this.phraseAléatoireToolStripMenuItem.Name = "phraseAléatoireToolStripMenuItem";
            this.phraseAléatoireToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.phraseAléatoireToolStripMenuItem.Text = "Phrase aléatoire";
            this.phraseAléatoireToolStripMenuItem.Click += new System.EventHandler(this.phraseAléatoireToolStripMenuItem_Click);
            // 
            // label_phrase
            // 
            this.label_phrase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_phrase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_phrase.Font = new System.Drawing.Font("Verdana", 10.25F);
            this.label_phrase.Location = new System.Drawing.Point(0, 391);
            this.label_phrase.Name = "label_phrase";
            this.label_phrase.ReadOnly = true;
            this.label_phrase.Size = new System.Drawing.Size(694, 36);
            this.label_phrase.TabIndex = 2;
            this.label_phrase.Text = "";
            // 
            // panel_letters
            // 
            this.panel_letters.AutoScroll = true;
            this.panel_letters.Location = new System.Drawing.Point(0, 23);
            this.panel_letters.Name = "panel_letters";
            this.panel_letters.Size = new System.Drawing.Size(694, 362);
            this.panel_letters.TabIndex = 3;
            // 
            // Mémoriser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(694, 427);
            this.Controls.Add(this.panel_letters);
            this.Controls.Add(this.label_phrase);
            this.Controls.Add(this.menuStrip_option);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip_option;
            this.MaximizeBox = false;
            this.Name = "Mémoriser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mémoriser";
            this.Load += new System.EventHandler(this.Mémoriser_Load);
            this.menuStrip_option.ResumeLayout(false);
            this.menuStrip_option.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip_option;
        private System.Windows.Forms.ToolStripMenuItem aléatoireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phraseAléatoireToolStripMenuItem;
        private System.Windows.Forms.RichTextBox label_phrase;
        private System.Windows.Forms.Panel panel_letters;
    }
}