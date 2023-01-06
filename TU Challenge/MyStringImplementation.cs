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
            for (int i = 0; i < a.Length; i++)
            {
                //resultat[i] = Char.ToLower(a[i]);
                if (a[i] >= 'A' && a[i] <= 'Z')
                {
                    resultat[i] = (char)(a[i] + ('a' - 'A') );
                }
                else if (a[i] >= '\u00C0' && a[i] <= '\u00FF')
                {
                    if (a[i] == '\u00C8')
                        resultat[i] = '\u00E8';
                    if (a[i] == '\u00C9')
                        resultat[i] = '\u00E9';
                    if (a[i] == '\u00CA')
                        resultat[i] = '\u00EA';
                    if (a[i] == '\u00CB')
                        resultat[i] = '\u00EB';
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
            string n = "";
            foreach (char c in a)
            {
                // Si le caractère est une voyelle, l'ajoute au StringBuilder
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'y' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U' || c == 'Y')
                {
                    if (c >= 'A' && c <= 'Z' && !n.Contains((char)(c + ('a' - 'A'))))
                    {
                            
                            n += (char)(c + ('a' - 'A'));
                    }
                    else if (!n.Contains(c))
                        n += c;
                }
            }
            return n;
        }
        public static string Reverse(string a)
        {
            string result = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                result += a[i];
            }
            return result;
        }

        public static string BazardString(string input)
        {
            string even = "";
            string unEven = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even += input[i].ToString();
                }
                else
                {
                    unEven += input[i].ToString();
                }
            }
            string result = even + unEven;
            return result;
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
