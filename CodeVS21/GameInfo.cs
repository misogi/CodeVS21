namespace CodeVS21
{
    public class GameInfo
    {
        /// <summary>
        /// ブロック数
        /// </summary>
        private int nums;

        public int NumberOfBlocks
        {
            get
            {
                return this.nums;
            }
        }

        public GameInfo(string infostr)
        {
            string[] infodata = infostr.Split(' ');
            if (infodata.Length == 5)
            {
                nums = int.Parse(infodata[4]);
            }
        }
    }
}
