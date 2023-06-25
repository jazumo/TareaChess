using Chess.Core.Interfaces;
using Chess.Core.Models;

namespace Chess.Infrastructure.PositionCheckers
{
    public class TxtChecker : ICheckOccupied
    {
        public bool IsOccupied(IList<Board_piece> _board, Piece _move, Board_piece _currentPiece)
        {
            foreach (var _piece in _board)
            {
                if (_move.PieceMovement == _piece.PieceCurrentPosition)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
