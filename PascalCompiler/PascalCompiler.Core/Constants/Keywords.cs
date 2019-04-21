using System.Collections.Generic;

namespace PascalCompiler.Core.Constants
{
    public static class Keywords
    {
        public static Dictionary<string, int> ByName = new Dictionary<string, int>
        {
            ["do"] = Dosy,
            ["if"] = Ifsy,
            ["in"] = Insy,
            ["of"] = Ofsy,
            ["or"] = Orsy,
            ["to"] = Tosy,
            ["and"] = Andsy,
            ["div"] = Divsy,
            ["end"] = Endsy,
            ["for"] = Forsy,
            ["mod"] = Modsy,
            ["nil"] = Nilsy,
            ["not"] = Notsy,
            ["set"] = Setsy,
            ["var"] = Varsy,
            ["case"] = Casesy,
            ["else"] = Elsesy,
            ["file"] = Filesy,
            ["goto"] = Gotosy,
            ["only"] = Onlysy,
            ["then"] = Thensy,
            ["type"] = Typesy,
            ["unit"] = Unitsy,
            ["uses"] = Usessy,
            ["with"] = Withsy,
            ["array"] = Arraysy,
            ["begin"] = Beginsy,
            ["const"] = Constsy,
            ["label"] = Labelsy,
            ["until"] = Untilsy,
            ["while"] = Whilesy,
            ["downto"] = Downtosy,
            ["export"] = Exportsy,
            ["import"] = Importsy,
            ["module"] = Modulesy,
            ["packed"] = Packedsy,
            ["record"] = Recordsy,
            ["repeat"] = Repeatsy,
            ["vector"] = Vectorsy,
            ["string"] = Stringsy,
            ["forward"] = Forwardsy,
            ["process"] = Processsy,
            ["program"] = Programsy,
            ["segment"] = Segmentsy,
            ["function"] = Functionsy,
            ["separate"] = Separatesy,
            ["interface"] = Interfacesy,
            ["procedure"] = Proceduresy,
            ["qualified"] = Qualifiedsy,
            ["implementation"] = Implementationsy,
        };

        public const int Dosy = 54;
        public const int Ifsy = 56;
        public const int Insy = 22;
        public const int Ofsy = 8;
        public const int Orsy = 23;           /* разделитель  !   */
        public const int Tosy = 55;
        

        /* ключевые  слова  длины  2 */

        public const int Andsy = 24;            /* разделитель   &  */
        public const int Divsy = 25;
        public const int Endsy = 13;
        public const int Forsy = 26;
        public const int Modsy = 27;
        public const int Nilsy = 89;
        public const int Notsy = 28;
        public const int Setsy = 29;
        public const int Varsy = 30;

        /*  ключевые  слова  длины  3 */

        public const int Casesy = 31;
        public const int Elsesy = 32;
        public const int Filesy = 57;
        public const int Gotosy = 33;
        public const int Onlysy = 90;
        public const int Thensy = 52;
        public const int Typesy = 34;
        public const int Unitsy = 35;
        public const int Usessy = 36;
        public const int Withsy = 37;

        /*  ключевые  слова   длины 4 */

        public const int Arraysy = 38;
        public const int Beginsy = 17;
        public const int Constsy = 39;
        public const int Labelsy = 40;
        public const int Untilsy = 53;
        public const int Whilesy = 41;

        /*  ключевые  слова   длины  5 */

        public const int Downtosy = 55;
        public const int Exportsy = 91;
        public const int Importsy = 92;
        public const int Modulesy = 93;
        public const int Packedsy = 42;
        public const int Recordsy = 43;
        public const int Repeatsy = 44;
        public const int Vectorsy = 45;
        public const int Stringsy = 46;

        /*  ключевые  слова    длины 6 */

        public const int Forwardsy = 47;
        public const int Processsy = 48;
        public const int Programsy = 3;
        public const int Segmentsy = 49;

        /*  ключевые  слова    длины 7 */

        public const int Functionsy = 77;
        public const int Separatesy = 78;

        /*  ключевые  слова    длины 8 */

        public const int Interfacesy = 79;
        public const int Proceduresy = 80;
        public const int Qualifiedsy = 94;

        /*  ключевые   слова   длины 9 */

        public const int Implementationsy = 81;

        /*  ключевые  слова    длины 14 */
    }
}
