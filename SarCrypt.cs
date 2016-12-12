﻿using System;
using System.Text;

namespace SargonCrypt
{
    class SarCrypt
    {
        private string alphabets;
        private string key;
        public SarCrypt(string alphabets, string key)
        {
            this.alphabets  = alphabets;
            this.key = key;
        }

        public string Generate(int size)
        {
            char[] chars = new char[size];
            Random rand = new Random();
            for (int i=0; i < size; i++)
            {
                chars[i] = alphabets[rand.Next(alphabets.Length)];
            }
            return new string(chars);
        }

        public string Encrypt(string input)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < input.Length ; i++)
            {
                int indexOfChar = alphabets.IndexOf(input[i]);
                int plus = (int)key[i % key.Length];
                int plus2 = 0;
                foreach (char c in key)
                {
                    plus2 += (int)c;
                }
                sb.Append(alphabets[(indexOfChar + plus + plus2) % alphabets.Length]);
            }
            return sb.ToString();
        }

    }
}

