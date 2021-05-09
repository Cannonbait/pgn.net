namespace OpeningMentor.Chess.Model.MoveText
{
    /// <summary>
    /// Represents a Rav (recursive annotated variations) entry in the move text.
    /// </summary>
    public class RavEntry : MoveTextEntry
    {
        /// <summary>
        /// Gets or sets the inner move text of the Rav.
        /// </summary>
        /// <value>
        /// The move text.
        /// </value>
        public MoveTextEntryList MoveText { get; set; }

        /// <summary>
        /// Initializes a <see cref="RavEntry"/>.
        /// </summary>
        /// <param name="moveText">The inner move text of the Rav.</param>
        public RavEntry(MoveTextEntryList moveText)
            : base(MoveTextEntryType.RecursiveAnnotationVariation)
        {
            MoveText = moveText;
        }
    }
}