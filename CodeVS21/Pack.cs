namespace CodeVS21
{
    using System.Linq;

    public class Pack
    {
        private int[,] blocks;

        public Pack(int length, string[] blockValues)
        {
            if (blockValues.Length != length)
            {
                throw new System.ArgumentException();
            }

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
    }
}
