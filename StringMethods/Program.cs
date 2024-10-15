using System.Text;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string sentence = "eVeryThing I nEed     iS jUst a LittLe         slEEp";
            string str= Capitalize(sentence);
            Console.WriteLine(str);


        }
        public static string Capitalize(string sentence)
        {
            string[] words=sentence.Split(" ");
            StringBuilder str = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length != 0)
                {
                    str.Append(Char.ToUpper(words[i][0]));
                    str.Append(words[i].Substring(1).ToLower());
                    str.Append(" ");
                }

            }
            return str.ToString().Trim();

        }


    }
}
