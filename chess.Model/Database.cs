using System.Collections.Generic;

namespace OpeningMentor.Chess.Model
{
    /// <summary>
    /// Pgn Database. Basically a collection of games.
    /// </summary>
    public class Database
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Database"/> class.
        /// </summary>
        public Database()
        {
            Games = new List<Game>();
        }

        /// <summary>
        /// Gets the games.
        /// </summary>
        /// <value>
        /// The games.
        /// </value>
        public List<Game> Games { get; private set; }
    }
}
