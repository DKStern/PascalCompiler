namespace PascalCompiler.Core.Structures
{
    /// <summary>
    /// Область действия
    /// </summary>
    public class Scope
    {
        /// <summary>
        /// Таблица идентификаторов области действия
        /// </summary>
        public IdentifierTable IdentifierTable { get; set; }

        /// <summary>
        /// Таблица типов области действия
        /// </summary>
        public TypeTable TypeTable { get; set; }

        /// <summary>
        /// Элемент стека области действия, непосредственно объемлющей данную
        /// </summary>
        public Scope EnclosingScope { get; set; }

        /// <summary>
        /// Создание области действия
        /// </summary>
        public Scope()
        {
            IdentifierTable = new IdentifierTable();
            TypeTable = new TypeTable();
        }
    }
}
