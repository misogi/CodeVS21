namespace CodeVS21
{
    public class GameInfo
    {
        /// <summary>
        /// ブロック数
        /// </summary>
        private int sum;

        private int width;

        private int height;

        private int lengthOfPack;

        private int numberOfPacks;

        public int Sum
        {
            get
            {
                return this.sum;
            }
        }

        public int Width
        {
            get
            {
                return this.width;
            }
        }

        public int Height
        {
            get
            {
                return this.height;
            }
        }

        public int LengthOfPack
        {
            get
            {
                return this.lengthOfPack;
            }
        }

        public int NumberOfPacks
        {
            get
            {
                return this.numberOfPacks;
            }
        }

        public GameInfo(string infostr)
        {
            string[] infodata = infostr.Split(' ');
            if (infodata.Length == 5)
            {
                this.width         = int.Parse(infodata[0]);
                this.height        = int.Parse(infodata[1]);
                this.lengthOfPack  = int.Parse(infodata[2]);
                this.sum           = int.Parse(infodata[3]);
                this.numberOfPacks = int.Parse(infodata[4]);
            }
        }
    }
}
