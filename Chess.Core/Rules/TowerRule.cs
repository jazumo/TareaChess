using Chess.Core.Models;

namespace Chess.Core.Rules
{
    public class TowerRule : BaseRule
    {
        public override bool IsMatch(Board_PieceProxy _piece, PieceProxy _move)
        {
            return (_move.ProxyType == "T");
        }

        protected override void MovePiece(Board_PieceProxy _boardpiece, PieceProxy _move)
        {

            var currentColumn = _boardpiece.Board_ProxyPosition[0];
            var currentRow = _boardpiece.Board_ProxyPosition[1];
            var nextColumn = _move.ProxyMovement[0];
            var nextRow = _move.ProxyMovement[0];

            if (((currentColumn == nextColumn) && (currentRow != nextRow)) || ((currentColumn != nextColumn) && (currentRow == nextRow)))
            {
                _boardpiece.UpdatePosition(_move.ProxyMovement);
                return;
            }

            Console.WriteLine($"EL MOVIMIENTO T{_move.ProxyPosition}-{_move.ProxyMovement} NO ES VALIDO");

        }
    }
}
