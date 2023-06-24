using System;
using System.IO;
using Chess.App;
using Chess.Core.Interfaces;
using Chess.Infrastructure.Readers;

class Program
{
    public static void Main()
    {
        string path = @"C:\Users\JOSE ZUNIGA\Desktop\trabajos U\Aplicaciones de Vanguardia\Repo\Chess/TestFile.txt";

        var engine = new ChessEngine(new TxtReader());

        engine.ReadFile(path);
    }
}