using Chess.Core.Models;

namespace Chess.Core.Interfaces
{
    public interface ICheckOccupied
    {
        bool IsOccupied(IList<Board_piece> _board, Piece _move, Board_piece _currentPiece);
    }
}
