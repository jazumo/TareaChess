using Chess.Core.Interfaces;
using Chess.Core.Models;

namespace Chess.App
{
    public class ChessEngine
    {
        public IList<Piece> Moves = new List<Piece>();
        public IList<Board_piece> Board = new List<Board_piece>();

        public IReader Reader;
        public ICheckOccupied Checker;

        public ChessEngine(IReader _reader, ICheckOccupied _checker)
        {
            Reader = _reader;
            Checker = _checker;
        }

        public void MovePieces()
        {
            foreach (var _move in Moves)
            {
                foreach (var _piece in Board)
                {
                    if (!Checker.IsOccupied(Board, _move, _piece))
                    {
                        MovePieces(new Board_PieceProxy(_piece), new PieceProxy(_move));
                    }
                }
            }
        }

        public static void MovePieces(Board_PieceProxy _boardpiece, PieceProxy _move)
        {
            var rulesengine = new PieceMoveRuleEngine.Builder()
                .WithTower()
                .WithBlackPawn()
                .WithWhitePawn()
                .WithHorse()
                .Build();

            rulesengine.ApplyRules(_boardpiece, _move);
        }

        public void BuildCommands(string path)
        {
            Console.WriteLine(Reader.ReadMoves(path, Moves));
        }

        public void BuildBoard(string path)
        {
            Console.WriteLine(Reader.ReadBoard(path, Board));
        }

        public void ReadMoves()
        {
            foreach (var _piece in Moves)
            {
                Console.WriteLine($"{_piece.PieceType}{_piece.PiecePosition}-{_piece.PieceMovement}");
            }
        }

        public void ReadBoard()
        {
            foreach (var _piece in Board)
            {
                Console.WriteLine($"{_piece.PieceType}{_piece.PieceCurrentPosition}-{_piece.PieceAllegiance}");
            }
        }
    }
}
