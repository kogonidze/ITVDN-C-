using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoder
{
    abstract class PatternConstants
    {
        public const string PrepositionPattern = @"( [пП]од | [Нн]а | [вВ] | [зЗ]а | [кК] | [иИ]з | [пП]о | [оО]б | [оО]т | [уУ] | [сС] |" + 
                                                @" [оО] | [оО]коло | [пП]ри | [пП]еред | [бБ]ез | [Мм]ежду | [Вв]округ | [Дд]ля | [Пп]ро } |" +
                                                @" [иИ]з-за | [иИ]з-под | [дД]о )";
    }
}
