using Chess.Core.Interfaces;
using Chess.Core.Models;

namespace Chess.Infrastructure.Converters
{
    public class TxtConverter : IConverter
    {
        public Piece ConvertMoves(string _piece)
        {
            //FORMAT
            //PIECE POSITION "-" MOVEMENT
            //Cb1-c3
            Piece added_piece = new Piece
            {
                PieceType = _piece[0].ToString(),
                PiecePosition = _piece[1].ToString() + _piece[2].ToString(),
                PieceMovement = _piece[4].ToString() + _piece[5].ToString()
            };

            return added_piece;
        }

        public Board_piece ConvertBoard(string _piece)
        {
            //FORMAT
            //PIECE POSITION "-" allegiance
            //Cb1-b
            Board_piece added_piece = new Board_piece
            {
                PieceType = _piece[0].ToString(),
                PieceCurrentPosition = _piece[1].ToString() + _piece[2].ToString(),
                PieceAllegiance = _piece[4].ToString()
            };

            return added_piece;
        }
    }
}
