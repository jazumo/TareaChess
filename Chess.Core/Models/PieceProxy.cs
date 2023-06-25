namespace Chess.Core.Models
{
    public class PieceProxy
    {
        protected readonly Piece ProxyPiece;

        public PieceProxy(Piece piece)
        {
            this.ProxyPiece = piece;
        }

        public string ProxyType => ProxyPiece.PieceType;

        public string ProxyPosition => ProxyPiece.PiecePosition;

        public string ProxyMovement => ProxyPiece.PieceMovement;

        public void UpdatePosition()
        {
            ProxyPiece.PiecePosition = ProxyPiece.PieceMovement;
        }

    }
}
