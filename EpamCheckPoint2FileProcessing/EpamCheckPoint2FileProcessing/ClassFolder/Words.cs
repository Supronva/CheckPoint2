using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamCheckPoint2FileProcessing
{
    class Words
    {
        public int CountWord { get; set; }
        public string LineWord { get; set; }
        public Words(string word, int count, string line)
        {
            CountWord = count;
            LineWord = line;
        }
    }
}
