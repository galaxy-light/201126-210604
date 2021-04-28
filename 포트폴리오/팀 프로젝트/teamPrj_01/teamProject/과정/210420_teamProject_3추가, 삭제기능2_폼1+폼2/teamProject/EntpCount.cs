namespace teamProject
{
    class EntpCount
    {
        public string medName { get; set; }
        public string medCom { get; set; }
        public string medCode { get; set; }
        public string medContain { get; set; }
        public string medListCode { get; set; }
        public int medCount { get; set; }        

        public EntpCount(string medName, string medCom, string medCode, string medContain, string medListCode, int medCount)
        {
            this.medName = medName;
            this.medCom = medCom;
            this.medCode = medCode;
            this.medContain = medContain;
            this.medListCode = medListCode;
            this.medCount = medCount;
        }

        public EntpCount()
        {

        }
    }
}
