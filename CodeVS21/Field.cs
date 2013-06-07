namespace CodeVS21
{
    /// <summary>
    /// The field.
    /// </summary>
    public class Field
    {
        #region Fields

        /// <summary>
        /// The cell.
        /// </summary>
        private int[,] cells;

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
            this.cells  = new int[width, height];
        }

        public void Fall(Pack pack, int position, int rotate)
        {
            
        }

        public int ValueOfCell(int column, int row)
        {
            return cells[column, row];
        }

        public int HeightOfLine(int column)
        {
            int lineheight = 0;
            for (int i = 0; i < this.height; i++ )
            {
                if (cells[column, i] > 0)
                {
                    lineheight = i;
                }
            }
            return lineheight;
        }

        #endregion
    }
}