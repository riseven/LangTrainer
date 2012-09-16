using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LangTrainer
{
    public partial class MainForm : Form
    {
        TextProcessor tp;
        List<object[]> rows = new List<object[]>();
        

        public MainForm()
        {
            InitializeComponent();
        }

        private void processTextButton_Click(object sender, EventArgs e)
        {
            textProcessorWorker.RunWorkerAsync();
        }

        private void textProcessorWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            const float READ_MILESTONE = 20.0f;
            const float SORT_MILESTONE = 60.0f;
            const float ACUM_MILESTONE = 20.0f;

            tp = new TextProcessor();

            DirectoryInfo dirInfo = new DirectoryInfo("C:\\Users\\Riseven\\Desktop\\texts");

            FileInfo[] finfos = dirInfo.GetFiles();

            for (int fileIndex = 0; fileIndex < finfos.Length ; fileIndex++)
            {
                tp.processFile(finfos[fileIndex]);

                textProcessorWorker.ReportProgress((int)(READ_MILESTONE * (fileIndex + 1) / finfos.Length));
            }
            textProcessorWorker.ReportProgress((int)READ_MILESTONE);

            Dictionary<string, int> dictionary = tp.WordFrequency;
            SortedDictionary<int, List<string>> sorted = new SortedDictionary<int, List<string>>();

            // Sort words by frequency
            int totalWords = 0;
            foreach (int freq in dictionary.Values)
            {
                totalWords += freq;
            }

            int sortedWords = 0;
            foreach (KeyValuePair<string, int> pair in dictionary)
            {
                sortedWords += pair.Value;
                if (sorted.ContainsKey(pair.Value) == false)
                {
                    List<string> newList = new List<string>();
                    newList.Add(pair.Key);
                    sorted[pair.Value] = newList;
                }
                else
                {
                    List<string> list = sorted[pair.Value];
                    list.Add(pair.Key);
                }

                textProcessorWorker.ReportProgress((int)(READ_MILESTONE + SORT_MILESTONE * sortedWords / totalWords));
            }
            textProcessorWorker.ReportProgress((int)(READ_MILESTONE + SORT_MILESTONE));

            int currentWords = 0;
            int currentIndex = 0;
            foreach (KeyValuePair<int, List<string>> pair in sorted.Reverse())
            {
                foreach (string word in pair.Value)
                {
                    currentWords += pair.Key;
                    currentIndex += 1;
                    int freq = (int)((((Int64)pair.Key) * 1000000) / totalWords);
                    int cummFreq = currentWords * 100 / totalWords;

                    rows.Add( new object[]{currentIndex, word, freq, cummFreq} );
                    textProcessorWorker.ReportProgress((int)(READ_MILESTONE + SORT_MILESTONE + ACUM_MILESTONE * currentWords / totalWords));
                }
            }
            textProcessorWorker.ReportProgress(100);

            System.Threading.Thread.Sleep(1000);
        }

        private void textProcessorWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach(object[] row in rows)
            {
                dictionaryDataGridView.Rows.Add(row);
            }
        }

        private void textProcessorWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            processProgressBar.Value = e.ProgressPercentage;
        }
    }
}
