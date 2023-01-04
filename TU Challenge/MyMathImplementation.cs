using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {

        static public int Add(int a, int b)
        {
            return a + b;
        }

        public static bool IsMajeur(int age)
        {
            if(age > 100 || age < 0)
                throw new System.ArgumentException("Logfile cannot be read-only");

            if (age >= 18)
                return true;
            else 
                return false;
        }

        public static bool IsEven(int a)
        {
            if (a % 2 == 0)
                return true;
            else
                return false;
        }

        public static bool IsDivisible(int a, int b)
        {
            return (a % b == 0);
        }

        public static bool IsPrimary(int a)
        {
            if (a < 2)
            {
                return false;
            }
            int racine = 1;
            while (racine * racine <= a)
            {
                racine++;
            }
            for (int i = 2; i < racine; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static List<int> GetAllPrimary(int a)
        {
            List<int> liste = new List<int>();

            for (int i = 1; i <= a; i++)
            {
                liste.Add(i);
            }

            List<int> listePremiers = liste.FindAll(IsPrimary);

            return listePremiers;
        }

        public static int Power2(int a)
        {

            return a * a;
        }

        public static int Power(int a, int b)
        {
            int temp = a;
            for(int i = 1; i < b; i++)
            {
                a *= temp;
            }
            return a;
        }

        public static int IsInOrder(int a, int b)
        {
            if (a < b)
                return 1;
            else if (a > b)
                return -1;
            else
                return 0;
        }

        public static bool IsListInOrder(List<int> list)
        {
            for(int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1])
                    return false;
            }
            return true;
        }

        public static List<int> Sort(List<int> toSort)
        {
            int n = toSort.Count;
            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (toSort[j] < toSort[min])
                    {
                        min = j;
                    }
                }
                int temp = toSort[min];
                toSort[min] = toSort[i];
                toSort[i] = temp;
            }
            return toSort;
        }

        public static List<int> GenericSort(List<int> toSort, Func<int, int, int> isInOrder)
        {
            throw new NotImplementedException();
        }

        public static int IsInOrderDesc(int arg1, int arg2)
        {
            throw new NotImplementedException();
        }
    }
}
