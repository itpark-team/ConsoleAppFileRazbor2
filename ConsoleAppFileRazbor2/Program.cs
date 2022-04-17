using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleAppFileRazbor2
{
    internal class Program
    {
        static string ReverseString(string text)
        {
            char temp;
            char[] tempText = text.ToCharArray();

            int count = tempText.Length / 2;

            for (int i = 0; i < count; i++)
            {
                temp = tempText[i];
                tempText[i] = tempText[text.Length - 1 - i];
                tempText[text.Length - 1 - i] = temp;
            }

            return new string(tempText);
        }

        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader("input.txt");
            StreamWriter streamWriter = new StreamWriter("output.txt");

            while (streamReader.EndOfStream == false)
            {
                string currentString = streamReader.ReadLine();
                currentString = ReverseString(currentString);
                streamWriter.WriteLine(currentString);
            }


            streamReader.Close();
            streamWriter.Close();
        }
    }
}
