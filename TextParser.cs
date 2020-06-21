using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Problem_D
{
    public class TextParser
    {
        private string textFromFile;
        private string[] splittedText;
        private List<Country> countryList;
        private List<Case> caseList;
        public TextParser(string textFromFile)
        {
            this.textFromFile = textFromFile;
            countryList = new List<Country>();
            caseList = new List<Case>();
        }

        public Case[] parse()
        {
            splittedText = textFromFile.Split("\r\n");

            for (int i = 0; i < splittedText.GetLength(0) - 1; i++)
            {
                int numbersOfCountries = Int32.Parse(splittedText[i]);
                for (int j = 0; j < numbersOfCountries; j++)
                {
                    string[] countryData = splittedText[++i].Split(" ");
                    string countryName = countryData[0];
                    int xl = Int32.Parse(countryData[1]);
                    int yl = Int32.Parse(countryData[2]);
                    int xh = Int32.Parse(countryData[3]);
                    int yh = Int32.Parse(countryData[4]);
                    
                    countryList.Add(new Country(countryName, xl, yl, xh, yh));
                }
                caseList.Add(new Case(countryList.ToArray()));
                countryList.Clear();
            }

            return caseList.ToArray();
        }

    }
}