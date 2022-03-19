using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Générateur_de_mot_de_passe
{
    public partial class Mémoriser : Form
    {
        internal List<string> words = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + @"\memo.txt").ToList();
        internal string[] phrases;
        public Mémoriser(string password)
        {
            InitializeComponent();

            this.Icon = Properties.Resources.icon;

            Password = password;

            phrases = new string[Password.Length];

            for (int i = 0; i < Password.Length; i++)
            {
                phrases[i] = Password[i].ToString();
            }

            label_phrase.Text = String.Join(" ", phrases);

            int x = 0, y = 0;
            for(int i = 0; i < Password.Length; i++)
            {
                UserControl_Lettre userControl_Lettre = new UserControl_Lettre(this, Password[i], i);
                userControl_Lettre.Location = new Point(x, y);
                panel_letters.Controls.Add(userControl_Lettre);
                x += userControl_Lettre.Width;
            }
        }

        private string Password { get; }

        private void Mémoriser_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Choisi un mot aléatoire
        /// </summary>
        private void RandomPickup()
        {
            foreach (Control ctrl in panel_letters.Controls)
            {
                if (ctrl is UserControl_Lettre)
                {
                    UserControl_Lettre UC = ctrl as UserControl_Lettre;
                    UC.RandomPickUp();
                }
            }
        }

        /// <summary>
        /// Choisi un mot pour le char spécifié
        /// </summary>
        /// <param name="cb"></param>
        /// <param name="rdnWord"></param>
        internal void ChoiceWordFor(int cb, string rdnWord)
        {
            phrases[cb] = rdnWord;

            label_phrase.Text = String.Join(" ", phrases);
        }

        /// <summary>
        /// Génère une phrase aléatoire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void phraseAléatoireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomPickup();
        }
    }
}
