using Chess.Core.Interfaces;

namespace Chess.Infrastructure.Readers
{
    public class TxtReader : IReader
    {
        public string Read(string path)
        {
            if (!File.Exists(path))
            {
                return "NO SE ENCONTRO EL ARCHIVO";
            }

            string concat = "";
            string last = "";
            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                while ((concat = sr.ReadLine()) != null)
                {
                    last = last + concat + "\n";
                }
            }
            return last;
        }
    }
}
