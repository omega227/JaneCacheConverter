using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JaneCacheConverter
{
    public sealed class Category
    {
        public Category(string name , BoardCollection boards)
        {
            Name = name;
            Boards = boards;
        }
        public string Name { get; private set; }
        public BoardCollection Boards { get; private set; }
    }
}
