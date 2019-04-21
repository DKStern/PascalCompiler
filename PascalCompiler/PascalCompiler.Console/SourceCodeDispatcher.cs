using System.IO;
using PascalCompiler.Core;

namespace PascalCompiler.Console
{
    class SourceCodeDispatcher : ISourceCodeDispatcher
    {
        public bool IsEnd { get; private set; }

        private StreamReader _reader;
        private StreamWriter _writer;
        
        /// <summary>
        /// Создание диспатчера для чтения и записи
        /// </summary>
        /// <param name="inputeFile">Входной файл</param>
        /// <param name="outputFile">Выходной файл</param>
        public SourceCodeDispatcher(string inputeFile, string outputFile)
        {
            _reader = new StreamReader(inputeFile);
            _writer = new StreamWriter(outputFile);
        }

        /// <summary>
        /// Считывание строки из файла
        /// </summary>
        /// <returns></returns>
        public string ReadLine()
        {
            var line = _reader.ReadLine();
            if (line == null)
                IsEnd = true;
            return line;
        }

        /// <summary>
        /// Запись строки в файл
        /// </summary>
        /// <param name="line">строка</param>
        public void WriteLine(string line)
        {
            _writer.WriteLine(line);
        }

        /// <summary>
        /// Закрытие диспатчера
        /// </summary>
        public void Close()
        {
            _reader.Close();
            _writer.Close();
        }
    }
}
