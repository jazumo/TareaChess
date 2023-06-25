using Chess.Core.Models;

namespace Chess.Core.Rules
{
    public abstract class BaseRule
    {
        public abstract bool IsMatch(Board_PieceProxy _piece, PieceProxy _move);

        protected virtual void MovePiece(Board_PieceProxy _boardpiece, PieceProxy _move)
        {
            Console.WriteLine("EL MOVIMIENTO NO ES VALIDO");
        }

        public void Apply(Board_PieceProxy _boardpiece, PieceProxy _move)
        {
            if (_boardpiece.Board_ProxyPosition == _move.ProxyPosition && _boardpiece.Board_ProxyType == _move.ProxyType)
            {
                MovePiece(_boardpiece, _move);
                return;
            }
        }
    }
}
