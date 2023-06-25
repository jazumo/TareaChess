using Chess.Core.Models;
namespace Chess.Core.Interfaces
{
    public interface IConverter
    {
        Piece ConvertMoves(string _piece);

        Board_piece ConvertBoard(string _piece);
    }
}
