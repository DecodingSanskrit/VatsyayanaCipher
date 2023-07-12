using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatsyayanaCipher
{
    public class SubstitutionCipher
    {
        private Dictionary<char, char> valuePairs = new Dictionary<char, char>();
        private Dictionary<char, char> keyPairs = new Dictionary<char, char>();
        private const string allLetters = "abcdefghijklmnopqrstuvwxyzABCDEFGHI" + "JKLMNOPQRSTUVWXYZ";
        public SubstitutionCipher(Dictionary<char,char> keyValues)
        {
            if (allLetters.Count() == keyValues.Count())
                valuePairs = keyValues;
            else
            {
                for (int i = 0; i < allLetters.Length; i++)
                {
                    valuePairs.Add(allLetters[i],
                        allLetters[(i + 0) % allLetters.Length]);
                }
            }
        }

        public SubstitutionCipher(int shiftValue)
        {
            for (int i = 0; i < allLetters.Length; i++)
            {
                valuePairs.Add(allLetters[i],
                    allLetters[(i + shiftValue) % allLetters.Length]);
            }

            for (int i = 0; i < allLetters.Length; i++)
            {
                keyPairs.Add(allLetters[i],
                    allLetters[(i - shiftValue + allLetters.Length) % allLetters.Length]);
            }
        }

        public string Encrypt(string textToEncrypt)
        {
            StringBuilder cipherText = new StringBuilder();

            // loop to generate ciphertext
            foreach (char c in textToEncrypt)
            {
                if (allLetters.IndexOf(c) != -1)
                {
                    cipherText.Append(valuePairs);
                }
                else
                {
                    cipherText.Append(c);
                }
            }

            return cipherText.ToString();
        }

        public string Decrypt(string textToDecrypt)
        {
            StringBuilder decryptedText = new StringBuilder();

            // loop to recover plain text
            foreach (char c in textToDecrypt)
            {
                if (allLetters.IndexOf(c) != -1)
                {
                    decryptedText.Append(keyPairs);
                }
                else
                {
                    decryptedText.Append(c);
                }
            }

            return decryptedText.ToString();
        }
    }
}
