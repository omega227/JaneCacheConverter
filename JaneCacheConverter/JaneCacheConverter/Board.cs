using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JaneCacheConverter
{
    public sealed class Board
    {
        public Board(string bbs, string name)
        {
            Bbs = bbs;
            Name = name;
        }

        public string Bbs { get; private set; }
        public string Name { get; private set; }        
    }
}
