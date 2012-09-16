using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LangTrainer
{
    class TextProcessor
    {
        private Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

        public Dictionary<string, int> WordFrequency
        {
            get
            {
                return wordFrequency;
            }
        }

        public TextProcessor()
        {
            
        }

        public void processFile(System.IO.FileInfo finfo)
        {
            char[] separators = { ' ', '"' };
            StreamReader sr = new StreamReader(finfo.Open(FileMode.Open));
            
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] words = line.Split(separators);

                foreach (string word in words)
                {
                    if (wordFrequency.ContainsKey(word) == false)
                    {
                        wordFrequency[word] = 1;
                    }
                    else
                    {
                        wordFrequency[word] += 1;
                    }
                }
            }
        }
    }
}
