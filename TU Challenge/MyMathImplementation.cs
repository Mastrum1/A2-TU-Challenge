using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static List<int> GenericSort(List<int> toSort, Func<int, int, int> isInOrder)
        {
            int save;
            for (int i = 1; i < toSort.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (isInOrder(toSort[i], toSort[j]) > 0)
                    {
                        save = toSort[j];
                        toSort[j] = toSort[i];
                        toSort[i] = save;
                    }
                }
            }
            return toSort;
        }

        public static List<int> GetAllPrimary(int a)
        {
            int count = 0;
            int NombrePremier = 0;
            List<int> Countlist = new List<int>();
            for (int i = 1; i <= a; i++)
            {
                for (int y = 1; y <= i; y++)
                {
                    if (i % y == 0)
                    {
                        count++;
                        NombrePremier = i;
                    }
                }
                if (count == 2)
                {
                    Countlist.Add(NombrePremier);
                    count = 0;
                }
                else
                {
                    count = 0;
                }
            }
            return Countlist;

        }

        public static bool IsDivisible(int a, int b)
        {
            if (a % b == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool IsEven(int a)
        {
            return (a % 2 == 0);
        }

        public static int IsInOrder(int a, int b)
        {
            if (a > b)
            {
                return -1;
            }
            else if (a < b)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static int IsInOrderDesc(int arg1, int arg2)
        {
            if (arg1 > arg2)
            {
                return 1;
            }
            else if (arg1 < arg2)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public static bool IsListInOrder(List<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] < list[i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsMajeur(int age)
        {
            if (age >= 150 || age < 0)
            {
                throw new ArgumentException();

            }

            return age >= 18;
        }


        public static bool IsPrimary(int a)
        {
            int count = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    count++;
                }

            }
            if (count == 2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static int Power(int a, int b)
        {
            int baseA = a;
            for (int i = 1; i < b; i++)
            {
                a = baseA * a;
            }
            return a;
        }

        public static int Power2(int a)
        {
            return a * a;
        }

        public static List<int> Sort(List<int> toSort)
        {
            int save;
            for (int i = 1; i < toSort.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (toSort[i] < toSort[j])
                    {
                        save = toSort[j];
                        toSort[j] = toSort[i];
                        toSort[i] = save;
                    }
                }
            }
            return toSort;
        }
    }
}