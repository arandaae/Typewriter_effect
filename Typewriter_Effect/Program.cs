using System;

namespace Typewriter_Effect
{
    class Program
    {
        static void Main()
        {
            Typewrite("Your text here...");
            Console.ReadKey();  

        }

        static void Typewrite(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(60);
            }
        }
    }
}
