using System;

namespace BaseballEx
{
    [Serializable()]
    public class Rank
    {
        private int count1;
        private int totalTime;
        private string rank1;

        public Rank(int count1, int totalTime, string rank1)
        {
            this.count1 = count1;
            this.totalTime = totalTime;
            this.rank1 = rank1;
        }

        public int Count1 { get => count1; set => count1 = value; }
        public int TotalTime { get => totalTime; set => totalTime = value; }
        public string Rank1 { get => rank1; set => rank1 = value; }


    }
}
