﻿using System.Collections.Generic;
using System.IO;
using OpeningMentor.Chess.Model;
using OpeningMentor.Chess.Parse;
using Microsoft.FSharp.Core;

namespace OpeningMentor.Chess.Pgn
{
    /// <summary>
    /// Pgn format reader.
    /// </summary>
    public class PgnReader
    {
        /// <summary>
        /// Creates a PgnReader. Not much more really. 
        /// </summary>
        public PgnReader() { }

        /// <summary>
        /// Reads a pgn database from a fileName.
        /// </summary>
        /// <param name="fileName">The fileName name.</param>
        /// <returns>A pgn database.</returns>
        public Database ReadFromFile(string fileName)
        {
            var p = new Parser();
            return p.ReadFromFile(fileName);
        }

        /// <summary>
        /// Reads a pgn database from a stream.
        /// </summary>
        /// <param name="stream">The stream.</param>
        /// <returns>A pgn database.</returns>
        public Database ReadFromStream(Stream stream)
        {
            var p = new Parser();
            return p.ReadFromStream(stream);
        }

        /// <summary>
        /// Reads a pgn database from a string.
        /// </summary>
        /// <param name="input">The string input.</param>
        /// <returns>A pgn database.</returns>
        public Database ReadFromString(string input)
        {
            var p = new Parser();
            return p.ReadFromString(input);
        }

        /// <summary>
        /// Reads a pgn database from a string.
        /// </summary>
        /// <param name="stream"></param>
        /// <returns>A pgn database.</returns>
        public IEnumerable<Chess.Model.Game> ReadGamesFromFile(string file)
        {
            var p = new Parser();
            foreach (var game in p.ReadGamesFromFile(file))
                yield return game;
        }

        /// <summary>
        /// Reads a pgn database from a string.
        /// </summary>
        /// <param name="stream"></param>
        /// <returns>A pgn database.</returns>
        public IEnumerable<Chess.Model.Game> ReadGamesFromStream(Stream stream)
        {
            var p = new Parser();
            foreach (var game in p.ReadGamesFromStream(stream))
                yield return game;
        }
    }
}
