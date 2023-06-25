using Chess.Core.Interfaces;
using Chess.Core.Models;
using Chess.Infrastructure.Converters;

namespace Chess.Infrastructure.Readers
{
    public class TxtReader : IReader
    {
        public IConverter _converter;

        public TxtReader(IConverter converter)
        {
            this._converter = converter;
        }

        public string ReadMoves(string path, IList<Piece> _moves)
        {
            if (!File.Exists(path))
            {
                return "NO SE ENCONTRO EL ARCHIVO";
            }

            string line = "";
            using (StreamReader sr = File.OpenText(path))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Piece new_piece = _converter.ConvertMoves(line);
                    _moves.Add(new_piece);
                }
            }
            return "SE HAN CARGADO LOS MOVIMIENTOS AL SISTEMA\n";
        }

        public string ReadBoard(string path, IList<Board_piece> _pieces)
        {
            if (!File.Exists(path))
            {
                return "NO SE ENCONTRO EL ARCHIVO";
            }

            string line = "";
            using (StreamReader sr = File.OpenText(path))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Board_piece new_piece = _converter.ConvertBoard(line);
                    _pieces.Add(new_piece);
                }
            }
            return "SE HA CARGADO EL TABLERO AL SISTEMA\n";
        }
    }
}
