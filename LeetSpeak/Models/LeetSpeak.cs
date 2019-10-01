using System;
namespace LeetSpeak
{
    public class Translator
    {
        public void User(string inputSentence)
        {
            char[] array = inputSentence.ToCharArray();
            
            for(int i=0; i<array.Length; i++)
            {
                if(array[i] == 'e')
                {
                    array[i] = '3';
                }
                if(array[i] == 'o')
                {
                    array[i] = '0';
                }
                if(array[i] == 'I')
                {
                    array[i] = '1';
                }
                if(array[i] == 't')
                {
                    array[i] = '7';
                }
                if(array[i] == 's')
                {
                    array[i] = 'Z';
                }
            }
            string result = string.Join("", array);
            Console.WriteLine(result);
        }
    }
}