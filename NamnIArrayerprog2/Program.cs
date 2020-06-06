using System;

namespace NamnIArrayerprog2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många namn vill du skriva in?");
            int num = int.Parse(Console.ReadLine());
            string[] namn = new string[num];
            for(int i = 0; i<namn.Length;i++)
            {
                namn[i]=Console.ReadLine();
            }
            Console.WriteLine("");
            Sortera(namn);
            foreach (string namn2 in namn)
            {
                Console.WriteLine(namn2);
            }
        }
        public static void Sortera(string[] namn)
        {
            string temp;
            for (int i = 0; i < namn.Length; i++)
            {
                for (int j = 0; j < namn.Length -1; j++)
                {
                    string namn1 = namn[j];
                    string namn2 = namn[j + 1];
                    int san = string.Compare(namn1, namn2);
                    if (san > 0)
                    {
                        temp = namn[j + 1];
                        namn[j + 1] = namn[j];
                        namn[j] = temp;
                    }
                }

            }
        }
}
    }