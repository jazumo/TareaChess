using Chess.Core.Models;

namespace Chess.Core.Rules
{
    public class WhitePawnRule : BaseRule
    {
        public override bool IsMatch(Board_PieceProxy _piece, PieceProxy _move)
        {
            return (_move.ProxyType == "P" && _piece.Board_ProxyAllegiance == "w");
        }

        protected override void MovePiece(Board_PieceProxy _boardpiece, PieceProxy _move)
        {
            int current = int.Parse(_boardpiece.Board_ProxyPosition[1].ToString());
            int next = int.Parse(_move.ProxyMovement[1].ToString());
            if (next == (current+1))
            {
                _boardpiece.UpdatePosition(_move.ProxyMovement);
            }
            else
            {
                Console.WriteLine($"EL MOVIMIENTO P{_move.ProxyPosition}-{_move.ProxyMovement} NO ES VALIDO");
            }
        }
    }
}
