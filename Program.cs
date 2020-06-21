using System;
using System.Diagnostics;

namespace Problem_D
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Nail\RiderProjects\Problem_D\Problem_D\euro.txt";
            FileReader reader = new FileReader(path);
            string textFromFile = reader.readFile();
            
            TextParser parser = new TextParser(textFromFile);
            Case[] cases = parser.parse();
            foreach (Case task in cases)
            {
                task.runCase();
            }

        }
    }
}