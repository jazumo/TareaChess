using System;
using System.IO;
using Chess.App;
using Chess.Core.Interfaces;
using Chess.Infrastructure;
using Chess.Infrastructure.Converters;
using Chess.Infrastructure.PositionCheckers;
using Chess.Infrastructure.Readers;

class Program
{
    public static void Main()
    {
        string moves_path = @"C:\Users\JOSE ZUNIGA\Desktop\trabajos U\Aplicaciones de Vanguardia\Repo\Chess/chess_moves.txt";
        string board_path = @"C:\Users\JOSE ZUNIGA\Desktop\trabajos U\Aplicaciones de Vanguardia\Repo\Chess/chess_board.txt";

        var engine = new ChessEngine(new TxtReader(new TxtConverter()), new TxtChecker());

        engine.BuildBoard(board_path);
        engine.BuildCommands(moves_path);

        engine.MovePieces();
    }
}