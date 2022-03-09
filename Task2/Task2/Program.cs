using System;

namespace Task2
{
    internal class Program
    {
        #region Overload Tasks 
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(Sahe(12,31,32,32));
        //}
        //static int Sahe(int r)
        //{
        //    if (r == 0) return -1;
        //    return 3 * r * r;

        //}
        //static int Sahe(int a, int b)
        //{
        //    if (a == 0||b==0)return -1;
        //    return a * b;
        //}
        //static int Sahe(int a, int b, int c)
        //{
        //    return 2 * (a * b + a * c + b * c);
        //}
        //static int Sahe(int a, int b, int c,int r)
        //{
        //    int p = 3;
        //    p = (a + b + c) / 2;
        //    return p * r;
        //}
        #endregion
        static void Main(string[] args)
        {
            string text = Console.ReadLine();//user text
            string word = Console.ReadLine();//user input
            char[] symbol = text.ToCharArray();

            Console.WriteLine(HasLetter(text,word)) ;
        }
        static string HasLetter(string text,char symbol)
        {
            bool hasA = false;
            foreach (char item in text)//Check each letter 
            {
                if (item == symbol)
                {
                    hasA = true;
                    break;
                }
            }
            if (hasA) return "have";
            else return "have'nt";
        }
        static bool HasLetter(string text, string word)
        {
            foreach (var word in text)
            {

            }
        }



    }
}
