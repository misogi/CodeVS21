namespace CodeVS21
{
    using System;

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

        private Pack[] packs;

        private Field field;

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

            this.packs = new Pack[this.NumberOfPacks];
            this.field = new Field(this.width, this.height);
        }

        public void ReadPacks()
        {
            string[] packValues;
            for(int j = 0; j < this.NumberOfPacks; j++)
            {
                packValues = new string[this.LengthOfPack];
                for (int i = 0; i < this.LengthOfPack; i++)
                {
                    packValues[i] = Console.ReadLine();
                }
                var endStr = Console.ReadLine();
                this.packs[j] = new Pack(this.LengthOfPack, packValues);
            }
        }

        public void WriteAnswers()
        {
            Random rnd = new Random();
            for (int i = 0; i < this.NumberOfPacks; i++)
            {
                int pos = rnd.Next(this.Width - this.LengthOfPack);
                Console.WriteLine(pos.ToString() + " 0");
            }
        }

        public void WriteGameInfo()
        {
            Console.WriteLine("Width: " + this.Width);
            Console.WriteLine("Height: " + this.Height);
            Console.WriteLine("Length: " + this.LengthOfPack);
            Console.WriteLine("Sum: " + this.Sum);
            Console.WriteLine("Num: " + this.NumberOfPacks);
        }
    }
}
