using System;
using System.Linq;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст - последовательность из 1 и 0");
            var text = Console.ReadLine();
            int lengText = text.ToString().Length;

            Encrypt(text, GenerKey(text));
            Console.WriteLine();

            Console.WriteLine("Вевдите зашифрованный текст");
            var encText = Console.ReadLine();
           
            Console.WriteLine("Введите ключ");
            var decKey = Console.ReadLine();

            Decrypt(encText, GetKey(decKey));
            Console.WriteLine();

            Console.ReadKey();
        }

        static int[] GenerKey(string text)
        {
            Random rand = new Random();
            int[] key = new int[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
              int randomNum = rand.Next(0, 99);
              key[i] = randomNum;
                
            }
            return key;
        }

        static void Encrypt(string text, int[] key)
        {
           
            int[] encr = text.Select(c => (int)char.GetNumericValue(c)).ToArray();
            
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    if (key[i] != encr[j])
                        encr[j] = 1;
                    else
                        encr[j] = 0;
                    Console.Write(encr[j]);
                }
                
            }
        }

        static void Decrypt(string decText, int[] decrKey)
        {
            int[] text = decText.Select(c => (int)char.GetNumericValue(c)).ToArray();

            for (int i = 0; i < decText.Length; i++)
            {
                for (int j = 0; j < decText.Length; j++)
                {
                    if (decrKey[i] != text[j])
                        text[j] = 0;
                    else
                        text[j] = 1;
                    Console.Write(text[j]);
                }

            }
        }

        static int[] GetKey (string decKey)
        {
            int[] decrKey = decKey.Select(c => (int)char.GetNumericValue(c)).ToArray();
            return decrKey;
        }
    }
}
