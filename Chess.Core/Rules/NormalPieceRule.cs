using Chess.Core.Models;
using System.Net;

namespace Chess.Core.Rules
{
    public class NormalPieceRule : BaseRule
    {
        public override bool IsMatch(Board_PieceProxy _piece, PieceProxy _move) => true;

        protected override void MovePiece(Board_PieceProxy _boardpiece, PieceProxy _move)
        {
            Console.WriteLine($"EL MOVIMIENTO {_move.ProxyPosition}-{_move.ProxyMovement} NO ES VALIDO");
        }
    }
}
