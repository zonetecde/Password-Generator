using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Générateur_de_mot_de_passe
{
    internal static class Generateur
    {
        public static List<char> caracteres = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '²', '&', 'é', '"', Convert.ToChar("'"), '(', '-', 'è', '_', 'ç', 'à', ')', '=', '$', '^', '*', 'ù', '!', ':', ';', ',', '°', '+', '£', 'µ', '%', '§', '/', '.', '?', '<', '>', '\\', '|', '[', '{', '#', '~', '}', '¤'};
        private static Random rdn = new Random();

        /// <summary>
        /// Génère un mot de passe suivant les paramètres choisit
        /// </summary>
        /// <returns>Mot de passe généré</returns>
        internal static string Generate()
        {
            string password = "";

            // Si au moins une des checks box est cocher, pour ne pas crée une boucle infinit.
            if (Properties.Settings.Default.CharSpecial || Properties.Settings.Default.Lettre || Properties.Settings.Default.Chiffre)
            {
                bool error;
                List<char> bannedChar = null;

                if (!String.IsNullOrEmpty(Properties.Settings.Default.CharBanned))
                {
                    bannedChar = Properties.Settings.Default.CharBanned.Split(',').Select(char.Parse).ToList();
                }

                // Pour la longueur du mot de passe
                for (int i = 0; i < Properties.Settings.Default.Length; i++)
                {
                    error = false;

                    // On prend un caractère aléatoire dans la liste
                    char aleatoryChar = caracteres[rdn.Next(0, caracteres.Count - 1)];

                    // On vérifie que il corresponde bien au paramètre
                    // *
                    // Si on doit pas avoir de char special
                    if (!Properties.Settings.Default.CharSpecial)
                    {
                        if (!Char.IsLetterOrDigit(aleatoryChar) || Char.Equals(aleatoryChar, 'µ'))
                        {
                            // C'est un caractère spécial et on n'en voulait pas donc on l'ajoute pas au mot de passe.
                            error = true;
                        }
                    }
                    // *
                    // Si on doit pas avoir de chiffre
                    if (!Properties.Settings.Default.Chiffre)
                    {
                        if (Char.IsDigit(aleatoryChar))
                        {
                            // C'est un chiffre et on en voulait pas donc on l'ajoute pas au mot de passe
                            error = true;
                        }
                    }
                    //*
                    // Si on doit pas avoir de lettre
                    if (!Properties.Settings.Default.Lettre)
                    {
                        if (Char.IsLetter(aleatoryChar))
                        {
                            // C'est une lettre et on n'en voulait pas donc on l'ajoute pas au mot de passe
                            error = true;
                        }
                    }
                    //*
                    // Ajoute une majscule aléatoirement au caractère si c'est une lettre et que on autorise les maj
                    if (Properties.Settings.Default.Majuscule && Char.IsLetter(aleatoryChar))
                    {
                        int prob = rdn.Next(100);
                        if (prob <= 50)
                        {
                            aleatoryChar = Char.ToUpper(aleatoryChar);
                        }
                    }
                    //*
                    // Si le caractère est dans la liste des chars bannis
                    if (bannedChar != null)
                    {
                        if (bannedChar.Contains(aleatoryChar))
                        {
                            // Il est dans la liste des char bannis donc on l'ajoute pas au mot de passe
                            error = true;
                        }
                    }

                    // Si il y a eu une erreur on l'ajoute pas est on recommence le tour jusqu'à avoir un char convenable.
                    if (error)
                    {
                        i--;
                    }
                    else
                    {
                        password += aleatoryChar;
                    }
                }

                // Avant de donner le mot de passe, on lui enlève tous ces accents si on ne doit pas en avoir
                if (!Properties.Settings.Default.Accent)
                {
                    password = RemoveDiacritics(password);
                }
            }

            return password;
        }

        /// <summary>
        /// Enlève tous les accents d'un string
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string RemoveDiacritics(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}