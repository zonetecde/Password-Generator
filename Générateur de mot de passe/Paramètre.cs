using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Générateur_de_mot_de_passe
{
    public partial class Paramètres : Form
    {
        public Paramètres()
        {
            InitializeComponent();

            // Set les paramètres par défaut :
            checkBox_caracteresSpeciauxAutoriser.Checked = Générateur_de_mot_de_passe.Properties.Settings.Default.CharSpecial;
            checkBox_chiffresAutoriser.Checked = Générateur_de_mot_de_passe.Properties.Settings.Default.Chiffre;
            checkBox_lettresAutoriser.Checked = Générateur_de_mot_de_passe.Properties.Settings.Default.Lettre;
            checkBox_majusculeAutoriser.Checked = Générateur_de_mot_de_passe.Properties.Settings.Default.Majuscule;
            checkBox_autoriserAccent.Checked = Générateur_de_mot_de_passe.Properties.Settings.Default.Accent;

            trackBar_passwordLength.Value = Générateur_de_mot_de_passe.Properties.Settings.Default.Length;
            label_passwordLength.Text = trackBar_passwordLength.Value.ToString();
            textBox_caracteresBannis.Text = Générateur_de_mot_de_passe.Properties.Settings.Default.CharBanned;

        }

        private void trackBar_passwordLength_Scroll(object sender, EventArgs e)
        {
            // Set le label de longueur de mdp
            label_passwordLength.Text = trackBar_passwordLength.Value.ToString();

            // Set dans les paramètres
            Générateur_de_mot_de_passe.Properties.Settings.Default.Length = trackBar_passwordLength.Value;
            Properties.Settings.Default.Save();
        }


        private void label_passwordLength_ValueChanged(object sender, EventArgs e)
        {
            // Set le label de longueur de mdp
            label_passwordLength.Text = trackBar_passwordLength.Value.ToString();

            // Set dans les paramètres
            Générateur_de_mot_de_passe.Properties.Settings.Default.Length = trackBar_passwordLength.Value;
            Properties.Settings.Default.Save();
        }

        private void button_saveAndQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox_majusculeAutoriser_CheckedChanged(object sender, EventArgs e)
        {
            // Change l'acceptation des majuscules
            Générateur_de_mot_de_passe.Properties.Settings.Default.Majuscule = checkBox_majusculeAutoriser.Checked;
            Properties.Settings.Default.Save();
        }

        private void checkBox_lettresAutoriser_CheckedChanged(object sender, EventArgs e)
        {
            // Change l'acceptation des lettres
            Générateur_de_mot_de_passe.Properties.Settings.Default.Lettre = checkBox_lettresAutoriser.Checked;
            Properties.Settings.Default.Save();

        }

        private void checkBox_chiffresAutoriser_CheckedChanged(object sender, EventArgs e)
        {
            // Change l'acceptation des chiffres
            Générateur_de_mot_de_passe.Properties.Settings.Default.Chiffre = checkBox_chiffresAutoriser.Checked;
            Properties.Settings.Default.Save();
        }

        private void checkBox_caracteresSpeciauxAutoriser_CheckedChanged(object sender, EventArgs e)
        {
            // Change l'acceptation des caractères spéciaux
            Générateur_de_mot_de_passe.Properties.Settings.Default.CharSpecial = checkBox_caracteresSpeciauxAutoriser.Checked;
            Properties.Settings.Default.Save();
        }

        private void checkBox_autoriserAccent_CheckedChanged(object sender, EventArgs e)
        {
            // Change l'acceptation des accents sur les lettres
            Générateur_de_mot_de_passe.Properties.Settings.Default.Accent = checkBox_autoriserAccent.Checked;
            Properties.Settings.Default.Save();
        }

        private void textBox_caracteresBannis_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_caracteresBannis.Text))
            {
                try
                {
                    panel_caracteresBannisIsCorrect.BackColor = Color.Green;

                    List<char> bannedChar = textBox_caracteresBannis.Text.Split(',').Select(char.Parse).ToList();

                    Properties.Settings.Default.CharBanned = textBox_caracteresBannis.Text;
                    Properties.Settings.Default.Save();
                }
                catch
                {
                    panel_caracteresBannisIsCorrect.BackColor = Color.Red;

                    Properties.Settings.Default.CharBanned = string.Empty;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                panel_caracteresBannisIsCorrect.BackColor = Color.Green;
                Properties.Settings.Default.CharBanned = string.Empty;
                Properties.Settings.Default.Save();
            }
        }

        private void Paramètres_Load(object sender, EventArgs e)
        {

        }
    }
}
