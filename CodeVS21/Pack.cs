namespace CodeVS21
{
    using System.Collections.Generic;
    using System.Linq;

    public class Pack
    {
        private int[,] blocks;

        private int length;

        public int Length
        {
            get
            {
                return this.length;
            }
        }

    public Pack(int length, string[] blockValues)
        {
            if (blockValues.Length != length)
            {
                throw new System.ArgumentException();
            }

            this.length = length;
            this.blocks = new int[length, length];

            foreach (var line in blockValues.Select((blockValue, i) => new {Value = blockValue, Index = i}))
            {
                var digits = line.Value.Split(' ');
                foreach (var digit in digits.Select((d, j) => new {Value = d, Index = j}))
                {
                    this.blocks[line.Index, digit.Index] = int.Parse(digit.Value);
                }
            }
        }

        public List<int> DropLine(int lineNum)
        {
            var line = new List<int>();
            for (int i = length - 1; i >= 0; i--)
            {
                int val = blocks[i, lineNum];
                if (val > 0)
                {
                    line.Add(val);
                }
            }
            return line;
        }
    }
}
