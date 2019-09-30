using System;
using LeetSpeak;

namespace LeetSpeak
{
    public class Program
    {
        static void Main()
        {
            string inputSentence;

            Console.WriteLine("Write a sentence you want translated into 'Leet Speak': ");
            inputSentence = Console.ReadLine();  

            if (inputSentence == "")
            {
                Console.WriteLine("That wasn't a sentence, Please try again.");
            }
            else
            {
            Translator NewTranslate = new Translator();
            NewTranslate.User(inputSentence);
            }

        }
    }
}