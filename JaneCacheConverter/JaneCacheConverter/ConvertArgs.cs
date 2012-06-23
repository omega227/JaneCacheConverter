using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JaneCacheConverter
{
    public sealed class ConvertArgs
    {
        public ConvertArgs(Jane2ch jane, ConvertOption option)
        {
            Jane = jane;
            Option = option;
        }
        public Jane2ch Jane { get; private set; }
        public ConvertOption Option { get; private set; }
    }
}
