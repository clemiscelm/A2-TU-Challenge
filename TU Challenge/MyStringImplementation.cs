using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static bool IsNullEmptyOrWhiteSpace(string input)
        {
            if (input == null || input.Length == 0 )
                return true;
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                    return false;    
            }
            return true;
        }

        public static string MixString(string a, string b)
        {
            
            if(a == null || a.Length == 0 || b == null || b.Length == 0)
                throw new System.ArgumentException("Logfile cannot be read-only");
            int longueur;
            if (a.Length >= b.Length)
                longueur = a.Length;
            else
                longueur = b.Length;


            string resultat = "";
            for (int i = 0; i < longueur; i++)
            {
                if (i < a.Length)
                {
                    resultat += a[i];
                }

                if (i < b.Length)
                {
                    resultat += b[i];
                }
            }

            return resultat;
        }

        public static string ToLowerCase(string a)
        {

            char[] resultat = new char[a.Length];
            // Parcourt tous les caractères de la chaîne
            for (int i = 0; i < a.Length; i++)
            {
                // Convertit le caractère en minuscule et l'ajoute au tableau
                //resultat[i] = Char.ToLower(a[i]);
                if (a[i] >= 'A' && a[i] <= 'Z')
                {
                    resultat[i] = (char)(a[i] + ('a' - 'A'));
                }
                else

                {
                    resultat[i] = a[i];
                }
            }
            string res = string.Join("", resultat);
            return res;
            
        }

        public static string Voyelles(string a)
        {
            throw new NotImplementedException();
        }

        public static string BazardString(string input)
        {
            throw new NotImplementedException();
        }

        public static string UnBazardString(string input)
        {
            throw new NotImplementedException();
        }

        public static string ToCesarCode(string input, int offset)
        {
            throw new NotImplementedException();
        }
    }
}
