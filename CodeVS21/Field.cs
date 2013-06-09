namespace CodeVS21
{
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// The field.
    /// </summary>
    public class Field
    {
        #region Fields

        /// <summary>
        /// The cell.
        /// </summary>
        private List<int>[] cells;

        private int height;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Field"/> class.
        /// </summary>
        /// <param name="width">
        /// The width.
        /// </param>
        /// <param name="height">
        /// The height.
        /// </param>
        public Field(int width, int height)
        {
            this.height = height;
            this.cells  = new List<int>[width];
            for(int i=0; i < cells.Length; i++)
            {
                this.cells[i] = new List<int>();
            }
        }

        public void Fall(Pack pack, int position, int rotate)
        {
            for (int i = 0; i < pack.Length; i++)
            {
                List<int> dropLine = pack.DropLine(i);
                if (dropLine.Count == 0)
                {
                    continue;
                }
                this.cells[position + i].AddRange(dropLine);
            }
        }

        public int ValueOfCell(int column, int row)
        {
            var line = cells[column];
            if (row >= line.Count)
            {
                return 0;
            }
            return line[row];
        }

        public int HeightOfLine(int column)
        {
            int lineheight = 0;
            for (int i = 0; i < this.height; i++ )
            {
                if (cells[column][i] > 0)
                {
                    lineheight = i;
                }
            }
            return lineheight;
        }

        #endregion
    }
}