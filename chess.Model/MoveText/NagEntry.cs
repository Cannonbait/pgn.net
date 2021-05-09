namespace OpeningMentor.Chess.Model.MoveText
{
    /// <summary>
    /// Represents a Nag (numeric annotation glyph) entry in the move text.
    /// </summary>
    public class NagEntry : MoveTextEntry
    {
        /// <summary>
        /// Gets or sets the Nag code.
        /// </summary>
        /// <value>
        /// The Nag code.
        /// </value>
        public int Code { get; set; }

        /// <summary>
        /// Initializes a <see cref="NagEntry"/>.
        /// </summary>
        /// <param name="code">The Nag code.</param>
        public NagEntry(int code)
            : base(MoveTextEntryType.NumericAnnotationGlyph)
        {
            Code = code;
        }
        /// <summary>
        /// The Nag representation in the move text.
        /// </summary>
        /// <returns>
        /// The Nag representation in the move text.
        /// </returns>
        public override string ToString()
        {
            return "$" + Code;
        }
    }
}