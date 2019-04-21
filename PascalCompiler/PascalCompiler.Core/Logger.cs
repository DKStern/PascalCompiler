using System.IO;

namespace PascalCompiler.Core
{
    public static class Logger
    {
        private static StreamWriter _symbolsWriter;

        static Logger()
        {
            _symbolsWriter = new StreamWriter("../../Test/logs.txt");
        }

        /// <summary>
        /// Запись символа
        /// </summary>
        /// <param name="symbol">Символ</param>
        public static void LogSymbol(string symbol)
        {
            _symbolsWriter.Write(symbol);
            _symbolsWriter.Write("|");
        }

        /// <summary>
        /// Закрытие логгера
        /// </summary>
        public static void Close()
        {
            _symbolsWriter.Close();
        }
    }
}
