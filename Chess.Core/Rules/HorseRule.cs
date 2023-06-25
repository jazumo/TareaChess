using Chess.Core.Models;

namespace Chess.Core.Rules
{
    public class HorseRule : BaseRule
    {
        public override bool IsMatch(Board_PieceProxy _piece, PieceProxy _move)
        {
            return (_move.ProxyType == "C");
        }

        protected override void MovePiece(Board_PieceProxy _boardpiece, PieceProxy _move)
        {
            int ColumnDifference = Math.Abs(_boardpiece.Board_ProxyPosition[0] - _move.ProxyMovement[0]);
            int RowDifference = Math.Abs(_boardpiece.Board_ProxyPosition[1] - _move.ProxyMovement[1]);
            if(((ColumnDifference == 2)&&(RowDifference == 1)) || ((ColumnDifference == 1) && (RowDifference == 2)))
            {
                _boardpiece.UpdatePosition(_move.ProxyMovement);
                return;
            }

            Console.WriteLine($"EL MOVIMIENTO C{_move.ProxyPosition}-{_move.ProxyMovement} NO ES VALIDO");
        }
    }
}
