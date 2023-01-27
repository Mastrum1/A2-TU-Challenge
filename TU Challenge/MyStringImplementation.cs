using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static string BazardString(string input)
        {

            char[] res = new char[input.Length / 2];
            char[] res2 = new char[input.Length / 2];
            int index = 0;
            string? result = null;
            bool test = true;

            for (int i = 0; i < input.Length; i++)
            {
                if (test)
                {
                    res[index] = input[i];
                    test = false;
                }
                else
                {
                    res2[index] = input[i];
                    test = true;
                    index++;
                }
            }

            index = 0;

            for (int j = 0; j < input.Length; j++)
            {
                if (index == res.Length)
                {
                    index = 0;
                }

                if (j < input.Length / 2)
                {
                    result += res[index];
                    index++;
                }
                else
                {
                    result += res2[index];
                    index++;
                }
            }
            return result;
        }

        public static bool IsNullEmptyOrWhiteSpace(string input)
        {
            if (input != null)
            {
                foreach (char s in input)
                {
                    if (s != ' ')
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static string MixString(string a, string b)
        {
            if (a == null || b == null
                || a == "" || b == "")
            {
                throw new ArgumentException();

            }

            int length;
            if (a.Length < b.Length)
            {
                length = b.Length;
            }
            else if (b.Length < a.Length)
            {
                length = a.Length;
            }
            else
            {
                length = a.Length;
            }

            string? result = null;

            for (int i = 0; i < length; i++)
            {
                if (a.Length - 1 < i)
                {
                    result += b[i];
                }
                else if (b.Length - 1 < i)
                {
                    result += a[i];
                }
                else
                {
                    result = result + a[i] + b[i];
                }
            }

            return result;
        }

        public static string Reverse(string a)
        {
            char[] res = new char[a.Length];
            string? result = null;
            int index = 0;

            for (int i = a.Length - 1; i >= 0; i--)
            {
                res[index] = a[i];
                index++;
            }

            for (int j = 0; j < res.Length; j++)
            {
                result += res[j];
            }

            return result;
        }

        public static string ToCesarCode(string input, int offset)
        {
            string res = null;
            int value = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    value = Convert.ToInt32(input[i]);

                    if (value + offset <= 122)
                    {
                        res += (char)(value + offset);
                    }
                    else
                    {
                        res += (char)(value + offset - 26);
                    }
                }
                else
                {
                    res += ' ';
                }

            }
            return res;
        }

        public static string ToLowerCase(string a)
        {
            char[] res = new char[a.Length];
            string? result = null;
            int i = 0;
            foreach (char c in a)
            {
                if ((int)c <= 90 && 65 <= (int)c)
                {
                    res[i] = (char)(a[i] + 32);
                }
                else if ((int)c <= 221 && 192 <= (int)c)
                {
                    res[i] = (char)(a[i] + 32);
                }
                else
                {
                    res[i] = a[i];
                }
                i++;
            }

            for (int j = 0; j < res.Length; j++)
            {
                result += res[j];
            }

            return result;
        }

        public static string UnBazardString(string input)
        {
            char[] res = new char[input.Length / 2];
            char[] res2 = new char[input.Length / 2];
            int index = 0;
            string? result = null;
            bool test = true;

            for (int i = 0; i < input.Length; i++)
            {
                if (index == res.Length)
                {
                    index = 0;
                }

                if (i < input.Length / 2)
                {
                    res[index] = input[i];
                    index++;
                }
                else
                {
                    res2[index] = input[i];
                    index++;
                }
            }

            index = 0;


            for (int j = 0; j < res.Length; j++)
            {
                result += res[j];
                result += res2[j];
            }

            return result;
        }

        public static string Voyelles(string a)
        {
            string? result = null;
            bool exist = false;
            string str = ToLowerCase(a);
            char[] voyelles = { 'a', 'e', 'i', 'o', 'u', 'y' };
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < voyelles.Length; j++)
                {
                    if (str[i] == voyelles[j])
                    {
                        exist = false;
                        if (result != null)
                        {
                            for (int k = 0; k < result.Length; k++)
                            {
                                if (result[k] == voyelles[j])
                                {
                                    exist = true;
                                }
                            }
                        }

                        if (!exist)
                        {
                            result += voyelles[j];
                        }
                    }
                }
            }

            return result;
        }
    }
}