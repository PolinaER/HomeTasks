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
            Encrypt(text);
            Console.WriteLine();

            Console.WriteLine("Вевдите зашифрованный текст");
            var encText = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Введите ключ");
            var decKey = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.ReadKey();
        }

        static int[] GenKey(int lengText)
        {
            int[] key = new int[lengText];


            return key;
        }

        static void Encrypt(string text)
        {
            int[] encr = new int[text.Length];
            var text1 = int.Parse(text);
            for (int i = 0; i < text.Length; i++)
            {
                encr[i] = text1 % 10;
                text1 = text1 / 10;
                
            }
            int[] text2 = text.Select(c => (int)char.GetNumericValue(c)).ToArray();
            
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    if (encr[i] != text2[j])
                        text2[j] = 1;
                    else
                        text2[j] = 0;
                    Console.Write(text2[j]);
                }
                
            }
        }

        static void Decrypt(string decText, int[] key)
        {
            int[] text = decText.Select(c => (int)char.GetNumericValue(c)).ToArray();

            for (int i = 0; i < decText.Length; i++)
            {
                for (int j = 0; j < decText.Length; j++)
                {
                    if (key[i] != text[j])
                        text[j] = 0;
                    else
                        text[j] = 1;
                    Console.Write(text[j]);
                }

            }
        }
    }
}
