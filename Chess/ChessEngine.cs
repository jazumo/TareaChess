using Chess.Core.Interfaces;
using Chess.Core.Models;
using System.Data;

namespace Chess.App
{
    public class ChessEngine
    {
        IList<Piece> Pieces;

        public IReader Reader;

        public ChessEngine(IReader _reader)
        {
            Reader = _reader;
        }

        public void ReadFile(string path)
        {
            Console.WriteLine(Reader.Read(path));
        }
    }
}
