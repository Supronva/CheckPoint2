using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamCheckPoint2FileProcessing
{
   public class Text
    {
        private string FilePath;

        private char[] Separator;

        public Text()
        {
            FilePath = "";
            Separator = new char[] { ',', '.', '!', '?', ' ', '(', ')', ':', ';' };
        }

        public Text(string filePath)
        {
            ReadFromFile(filePath);
        }

        public void ReadFromFile(string filePath)
        {
            FilePath = filePath;
            string line;
            int CountLine = 0;
            StreamReader file = File.OpenText(FilePath);
            Dictionary<string, Words> MyDictionary = new Dictionary<string, Words>();
            while ((line = file.ReadLine()) != null)
            {
                CountLine++;
                string[] str;
                str = line.Split(Separator, StringSplitOptions.RemoveEmptyEntries);
                foreach (string i in str)
                {
                    if (!MyDictionary.ContainsKey(i))
                        MyDictionary.Add(i, new Words(i, 1, CountLine.ToString()));
                    else
                    {
                        (MyDictionary[i] as Words).CountWord++;
                        (MyDictionary[i] as Words).LineWord = (MyDictionary[i] as Words).LineWord + " " + CountLine.ToString();
                    }
                }
            }
            ICollection<string> keys = MyDictionary.Keys.OrderBy(x => x).ToList();

            foreach (string k in keys)
            {
                Console.WriteLine(k + "...." + (MyDictionary[k] as Words).CountWord + ":" + (MyDictionary[k] as Words).LineWord);
            }
        }
    }
}
