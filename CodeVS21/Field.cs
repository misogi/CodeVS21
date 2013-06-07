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
        private int[,] cell;

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
            this.cell = new int[width, height];
        }

        public void Fall(Pack pack, int position, int rotate)
        {
            
        }
        #endregion
    }
}