using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Générateur_de_mot_de_passe
{
    public partial class UserControl_Lettre : UserControl
    {
        int x = 0, y = 0;
        List<string> wordToAdd = new List<string>();
        List<string> relativeWords;
        TextBox textBox = new TextBox();
        public static Random rdn = new Random();
        string rdnWord = string.Empty;

        public char Lettre { get; }
        public Mémoriser Mémoriser { get; }
        public int Cb { get; }
        public List<char> alphabet = new List<char>()
        {
            'a',
            'b',
            'c',
            'd',
            'e',
            'f',
            'g',
            'h',
            'i',
            'j',
            'k',
            'l',
            'm',
            'n',
            'o',
            'p',
            'q',
            'r',
            's',
            't',
            'u',
            'v',
            'w',
            'x',
            'y',
            'z'
        };

        public UserControl_Lettre(Mémoriser mémoriser, char lettre, int cb)
        {
            InitializeComponent();

            label_lettre.Text = lettre.ToString();


            if (Char.IsLetter(lettre) && !lettre.Equals('µ'))
            {
                this.panel_words.MouseWheel += new MouseEventHandler(panel_MouseScroll);
                lettre = Convert.ToChar(Generateur.RemoveDiacritics(lettre.ToString()));

                int indexDansAlphabet = alphabet.IndexOf(char.ToLower(lettre));
                if(indexDansAlphabet == -1)
                {
                    indexDansAlphabet = 12;
                }
                try
                {
                    relativeWords = mémoriser.words[indexDansAlphabet].Split(',').ToList();
                }
                catch
                {
                    MessageBox.Show(lettre.ToString() + " " + indexDansAlphabet) ;
                }

                // Ajout une textbox de recherche
                textBox.Location = new Point(3, 69);
                textBox.Size = new Size(120, 20);
                textBox.TextChanged += TextBox_TextChanged;
                this.Controls.Add(textBox);
                y += textBox.Height;

                int maxW = 0;
                foreach (string word in relativeWords)
                {
                    if (maxW <= 20)
                    {
                        Label word_label = new Label();
                        word_label.UseMnemonic = false;
                        word_label.Text = word;
                        word_label.Font = new Font("Verdana", 10);
                        word_label.TextAlign = ContentAlignment.MiddleCenter;
                        word_label.AutoSize = false;
                        word_label.Size = new Size(126, 38);
                        word_label.Location = new Point(x, y);
                        word_label.MouseDown += new MouseEventHandler(selectedWord);
                        panel_words.Controls.Add(word_label);
                        if (word_label.Text.Equals(rdnWord))
                        {
                            word_label.BackColor = Color.LightGray;
                        }
                        y += word_label.Height;

                        maxW++;
                    }
                    else
                        wordToAdd.Add(word);
                }

                Lettre = lettre;

                textBox.BringToFront();
            }
            else if(!Char.IsDigit(lettre))
            {
                relativeWords = new List<string>();

                // Ajout une textbox de recherche
                textBox.Location = new Point(3, 69);
                textBox.Size = new Size(120, 20);
                this.Controls.Add(textBox);
                y += textBox.Height;

                Label word_label = new Label();
                word_label.UseMnemonic = false;
                word_label.Text = lettre.ToString();
                word_label.Font = new Font("Verdana", 10);
                word_label.TextAlign = ContentAlignment.MiddleCenter;
                word_label.AutoSize = false;
                word_label.Size = new Size(126, 38);
                word_label.Location = new Point(x, y);
                word_label.MouseDown += new MouseEventHandler(selectedWord);
                panel_words.Controls.Add(word_label);
                if (word_label.Text.Equals(rdnWord))
                {
                    word_label.BackColor = Color.LightGray;
                }
                textBox.BringToFront();

                relativeWords.Add(word_label.Text);
            }
            else
            {
                relativeWords = new List<string>();

                // Ajout une textbox de recherche
                textBox.Location = new Point(3, 69);
                textBox.Size = new Size(120, 20);
                this.Controls.Add(textBox);
                y += textBox.Height;

                Label word_label = new Label();
                word_label.UseMnemonic = false;
                word_label.Text = lettre.ToString();
                word_label.Font = new Font("Verdana", 10);
                word_label.TextAlign = ContentAlignment.MiddleCenter;
                word_label.AutoSize = false;
                word_label.Size = new Size(126, 38);
                word_label.Location = new Point(x, y);
                word_label.MouseDown += new MouseEventHandler(selectedWord);
                if (word_label.Text.Equals(rdnWord))
                {
                    word_label.BackColor = Color.LightGray;
                }
                panel_words.Controls.Add(word_label);
                y += word_label.Height;
                relativeWords.Add(word_label.Text);

                Label word_labelInLetter = new Label();
                word_labelInLetter.UseMnemonic = false;
                int chiffre = Convert.ToInt32(lettre.ToString());
                switch (chiffre)
                {
                    case 0:
                        word_labelInLetter.Text = "zéro";
                        break;
                    case 1:
                        word_labelInLetter.Text = "un";
                        break;
                    case 2:
                        word_labelInLetter.Text = "deux";
                        break;
                    case 3:
                        word_labelInLetter.Text = "trois";
                        break;
                    case 4:
                        word_labelInLetter.Text = "quatre";
                        break;
                    case 5:
                        word_labelInLetter.Text = "cinq";
                        break;
                    case 6:
                        word_labelInLetter.Text = "six";
                        break;
                    case 7:
                        word_labelInLetter.Text = "sept";
                        break;
                    case 8:
                        word_labelInLetter.Text = "huit";
                        break;
                    case 9:
                        word_labelInLetter.Text = "neuf";
                        break;

                        
                }
                relativeWords.Add(word_label.Text);

                word_labelInLetter.Font = new Font("Verdana", 10);
                word_labelInLetter.TextAlign = ContentAlignment.MiddleCenter;
                word_labelInLetter.AutoSize = false;
                word_labelInLetter.Size = new Size(126, 38);
                word_labelInLetter.Location = new Point(x, y);
                word_labelInLetter.MouseDown += new MouseEventHandler(selectedWord);

                if (word_labelInLetter.Text.Equals(rdnWord))
                {
                    word_labelInLetter.BackColor = Color.LightGray;
                }
                panel_words.Controls.Add(word_labelInLetter);

                textBox.BringToFront();
            }

            Mémoriser = mémoriser;
            Cb = cb;
        }

        /// <summary>
        /// Séléctionne le mot 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectedWord(object sender, MouseEventArgs e)
        {
            foreach(var ctrl in panel_words.Controls)
            {
                if(ctrl is Label)
                {
                    (ctrl as Label).BackColor = Color.FromName("Control");
                }
            }
            (sender as Label).BackColor = Color.LightGray;
            rdnWord = (sender as Label).Text;
            Mémoriser.ChoiceWordFor(Cb, (sender as Label).Text);
        }

        /// <summary>
        /// Choisi un mot au pif
        /// </summary>
        internal void RandomPickUp()
        {

             rdnWord = relativeWords[rdn.Next(0, relativeWords.Count - 1)];
            foreach(var label in panel_words.Controls)
            {
                if(label is Label)
                {
                    if((label as Label).Text.Equals(rdnWord))
                    {
                        (label as Label).BackColor = Color.LightGray;
                    }
                    else
                        (label as Label).BackColor = Color.FromName("Control");
                }
            }

            Mémoriser.ChoiceWordFor(Cb, rdnWord);
        }

        /// <summary>
        /// Recherche dans la liste des mots 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            clearAllWord();

            if (!String.IsNullOrEmpty(textBox.Text))
            {
                int maxW = 0;

                foreach (var word in relativeWords)
                {
                    if (maxW <= 20)
                    {
                        if (Generateur.RemoveDiacritics(word).Contains(Generateur.RemoveDiacritics(textBox.Text).ToLower()))
                        {
                            Label word_label = new Label();
                            word_label.UseMnemonic = false;
                            word_label.Text = word;
                            word_label.Font = new Font("Verdana", 10);
                            word_label.TextAlign = ContentAlignment.MiddleCenter;
                            word_label.AutoSize = false;
                            word_label.Size = new Size(126, 38);
                            word_label.Location = new Point(x, y);
                            panel_words.Controls.Add(word_label);
                            word_label.MouseDown += new MouseEventHandler(selectedWord);

                            if (word_label.Text.Equals(rdnWord))
                            {
                                word_label.BackColor = Color.LightGray;
                            }

                            y += word_label.Height;

                            maxW++;
                        }
                    }
                    else
                    {
                        wordToAdd.Add(word);
                    }

                }
            }
            else
            {
                int maxW = 0;

                foreach (string word in relativeWords)
                {
                    if (maxW <= 20)
                    {
                        Label word_label = new Label();
                        word_label.UseMnemonic = false;
                        word_label.Text = word;
                        word_label.Font = new Font("Verdana", 10);
                        word_label.TextAlign = ContentAlignment.MiddleCenter;
                        word_label.AutoSize = false;
                        word_label.Size = new Size(126, 38);
                        word_label.Location = new Point(x, y);
                        word_label.MouseDown += new MouseEventHandler(selectedWord);
                        panel_words.Controls.Add(word_label);

                        y += word_label.Height;


                        if (word.Equals(rdnWord))
                        {
                            word_label.BackColor = Color.LightGray;
                        }

                        maxW++;
                    }
                    else
                        wordToAdd.Add(word);
                }
            }
        }

        /// <summary>
        /// Supprime tous les mots dans le panel
        /// </summary>
        private void clearAllWord()
        {
            List<Control> toDelete = new List<Control>();
            foreach(Control ctrl in panel_words.Controls)
            {
                if(ctrl is Label)
                {
                    toDelete.Add(ctrl);
                }
            }

            foreach (var delete in toDelete)
            {
                panel_words.Controls.Remove(delete);
            }

            x = 0;
            y = textBox.Height;
            wordToAdd.Clear();
        }

        private void panel_MouseScroll(object sender, MouseEventArgs e)
        {
            if (panel_words.VerticalScroll.Value > panel_words.VerticalScroll.Maximum - panel_words.VerticalScroll.LargeChange)
            {
                addWordToList();
            }
        }

        /// <summary>
        /// Ajoute des mots en bas de la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_words_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue == panel_words.VerticalScroll.Maximum - panel_words.VerticalScroll.LargeChange + 1)
            {
                addWordToList();
            }
        }

        private void panel_words_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControl_Lettre_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Ajoute de nouveau mot à la liste 
        /// </summary>
        private void addWordToList()
        {
            if (wordToAdd.Any())
            {
                int temp = panel_words.VerticalScroll.Value;
                panel_words.VerticalScroll.Value = 0;

                int maxW = 0;

                // Les mots à supprimerde la liste vu qui seront déjà ajouté
                List<string> toRemove = new List<string>();

                foreach (string word in wordToAdd)
                {
                    if (maxW <= 20)
                    {
                        Label word_label = new Label();
                        word_label.UseMnemonic = false;
                        word_label.Text = word;
                        word_label.Font = new Font("Verdana", 10);
                        word_label.TextAlign = ContentAlignment.MiddleCenter;
                        word_label.AutoSize = false;
                        word_label.Size = new Size(126, 38);
                        word_label.Location = new Point(x, y);
                        word_label.MouseDown += new MouseEventHandler(selectedWord);
                        panel_words.Controls.Add(word_label);

                        if(word.Equals(rdnWord))
                        {
                            word_label.BackColor = Color.LightGray;
                        }


                        y += word_label.Height;

                        toRemove.Add(word);
                        maxW++;
                    }
                }

                foreach (var remove in toRemove)
                {
                    wordToAdd.Remove(remove);
                }


                panel_words.VerticalScroll.Value = temp;
                panel_words.PerformLayout();
            }
        }
    }
}
