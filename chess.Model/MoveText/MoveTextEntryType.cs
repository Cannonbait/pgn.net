namespace chess.Model.MoveText
{
    /// <summary>
    /// Move Text entry types.
    /// </summary>
    public enum MoveTextEntryType
    {
        /// <summary>Move Pair (white + black)</summary>
        MovePair,
        /// <summary>Single Move (white or black)</summary>
        SingleMove,
        /// <summary>Move text entry indicating the game end result</summary>
        GameEnd,
        /// <summary>Comment</summary>
        Comment,
        /// <summary>A Nag (Numeric Annotation Glyph)</summary>
        NumericAnnotationGlyph,
        /// <summary>A Rav (Recursive Annotation Variation)</summary>
        RecursiveAnnotationVariation
    }
}
