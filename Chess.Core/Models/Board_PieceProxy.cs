namespace Chess.Core.Models
{
    public class Board_PieceProxy
    {
        protected readonly Board_piece ProxyBoard_Piece;

        public Board_PieceProxy(Board_piece _board_piece)
        {
            this.ProxyBoard_Piece = _board_piece;
        }
        public string Board_ProxyType => ProxyBoard_Piece.PieceType;

        public string Board_ProxyPosition => ProxyBoard_Piece.PieceCurrentPosition;

        public string Board_ProxyAllegiance => ProxyBoard_Piece.PieceAllegiance;

        public void UpdatePosition(string _position)
        {
            Console.WriteLine($"EL MOVIMIENTO {Board_ProxyType}{Board_ProxyPosition}-{_position} ES VALIDO");
            ProxyBoard_Piece.PieceCurrentPosition = _position;
        }
    }
}
