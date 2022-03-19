using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Timers;
using System.Windows.Forms;

namespace Générateur_de_mot_de_passe
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.icon;
        }

        /// <summary>
        /// Remet le texte normal après avoir copier le mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            label_title.Text = "Mot de passe généré :";
        }

        private void button_parameter_Click(object sender, EventArgs e)
        {
            // Ouvre les paramètres
            Paramètres paramètres_window = new Paramètres();
            paramètres_window.Show();

            if(!String.IsNullOrEmpty(textBox_modifyPass.Text))
                label_password.Text = textBox_modifyPass.Text;
            textBox_modifyPass.Visible = false;
        }

        /// <summary>
        /// Change la taille du label pour pas que le texte dépasse
        /// </summary>
        /// <param name="font"></param>
        internal void ChangeLabelFont(Font font)
        {
            label_password.Font = font;
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.Length > 30)
            {
                label_password.Font = new Font("Consolas", 10);
            }
            else
            {
                label_password.Font = new Font("Consolas", 26.25f);
            }

            label_password.Text = textBox_modifyPass.Text;
            textBox_modifyPass.Visible = false;
            // Génère un mot de passe
            label_password.Text = 
            Generateur.Generate();
        }


        private void Main_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Modifie le mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_password_DoubleClick(object sender, EventArgs e)
        {
            textBox_modifyPass.Text = label_password.Text;
            textBox_modifyPass.Visible = true;

            this.ActiveControl = textBox_modifyPass;
        }

        /// <summary>
        /// Copie le mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_copy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(label_password.Text);

                label_title.Text = ("Mot de passe copié dans le presse papier !");
                var t = new System.Timers.Timer();
                t.Interval = 1500;
                t.AutoReset = false;
                t.Start();

                t.Elapsed += new ElapsedEventHandler(TimerElapsed);
            }
            catch
            {

            }
        }

        /// <summary>
        /// Ouvre la fenêtre de mémorisation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_memoriser_MouseDown(object sender, MouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(label_password.Text))
            {
                Mémoriser mémoriser = new Mémoriser(label_password.Text);
                mémoriser.Show();
            }
        }
    

        /// <summary>
        /// Enlève le focus sur la textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_modifyPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = label_password;
                textBox_modifyPass.Visible = false;
                label_password.Text = textBox_modifyPass.Text;
            }
        }
    }
}
