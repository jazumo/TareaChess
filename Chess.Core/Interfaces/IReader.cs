using Chess.Core.Models;

namespace Chess.Core.Interfaces;

public interface IReader
{
    string ReadMoves(string path, IList<Piece> _moves);

    string ReadBoard(string path, IList<Board_piece> _pieces);
}

