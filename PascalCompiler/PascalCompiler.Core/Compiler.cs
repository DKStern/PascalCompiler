using PascalCompiler.Core.Modules;

namespace PascalCompiler.Core
{
    public class Compiler
    {
        private readonly ISourceCodeDispatcher _sourceCodeDispatcher; //Диспатчер для чтения и записи
        private readonly Context _context; //Контекст
        private readonly IoModule _ioModule; //Модуль ввода/вывода
        private readonly LexicalAnalyzerModule _lexicalAnalyzerModule; //Лексический модуль
        private readonly SyntacticalAnalyzerModule _syntacticalAnalyzerModule; //Синтаксический модуль

        /// <summary>
        /// Создание анализатора кода для языка Pascal
        /// </summary>
        /// <param name="sourceCodeDispatcher">Диспатчер для чтения и записи</param>
        public Compiler(ISourceCodeDispatcher sourceCodeDispatcher)
        {
            _context = new Context(sourceCodeDispatcher);
            _sourceCodeDispatcher = sourceCodeDispatcher;
            _ioModule = new IoModule(_context);
            _lexicalAnalyzerModule = new LexicalAnalyzerModule(_context, _ioModule);
            _syntacticalAnalyzerModule = new SyntacticalAnalyzerModule(_context, _lexicalAnalyzerModule);
        }

        /// <summary>
        /// Запуск анализатора
        /// </summary>
        public void Start()
        {
            _syntacticalAnalyzerModule.Program();
            _sourceCodeDispatcher.Close();
            Logger.Close();
        }
    }
}
