using System;

namespace List7
{
    class Program
    {
        static string FinnsIBåda(string[] list1, string[] list2)
        {
            string sentence = "";
            List<string> words = new List<string>();
            for (int i = 0; i < list1.Length; i++)
            {
                for(int j = 0; j < list2.Length; j++)
                {
                    if (list1[i] == list2[j] && (words.Contains(list1[i]) == false))
                    {
                        words.Add(list1[i]);
                        sentence += " " + list1[i];
                    }
                }
            }
            return sentence;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FinnsIBåda(("a b b c hej").Split(" "), ("hej a a b programmering").Split(" ")));
        }
    }
}