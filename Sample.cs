using System;
using SargonCrypt;

    class Sample
    {
        public static void Main(string[] args)
        {
            string alphabets = "abcdefghjklmnpqrstuvwyxzABCDEFGHJKLMNPQRSTUVWXYZ23456789";
            string key = "5argondesu";

            SarCrypt sarCrypt = new SarCrypt(alphabets, key);
            string sampleGen = sarCrypt.Generate(6);

            Console.WriteLine("Sample SarText : " + sampleGen);
            Console.WriteLine("Sample SarCrypt : " + sarCrypt.Encrypt(sampleGen));
            while(true)
            {
                Console.WriteLine("Type something");
                string input = Console.ReadLine();
                Console.WriteLine(sarCrypt.Encrypt(input));
            }
        }
    }
