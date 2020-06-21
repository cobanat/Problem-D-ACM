using System;
using System.IO;

namespace Problem_D
{
    public class FileReader
    {
        private string path;
        public FileReader(string path)
        {
            this.path = path;
        }

        public string readFile()
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("File does not exist!");
            }

            string textFromFile;
            using (FileStream fileStream = File.OpenRead(path))
            {
                byte[] buff = new byte[fileStream.Length];
                fileStream.Read(buff, 0, buff.Length);
                textFromFile = System.Text.Encoding.Default.GetString(buff);
            }

            return textFromFile;
        }
    }
}