using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace JaneCacheConverter
{
    public sealed class CategoryCollection : System.Collections.ObjectModel.Collection<Category>
    {
        public CategoryCollection()
        {
            Load();
        }

        public bool Loaded { get; set; }
        public void Load()
        {
            XmlDocument bbsMenu = new XmlDocument();
            using (Stream xmlStream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("JaneCacheConverter.bbs.xml"))
            {
                bbsMenu.Load(xmlStream);
            }
            foreach (XmlElement categoryElement in bbsMenu.GetElementsByTagName("category"))
            {
                BoardCollection boards = new BoardCollection();
                foreach (XmlElement boardElement in categoryElement.ChildNodes)
                {
                    string bbs = boardElement.GetAttribute("dir");
                    string name = boardElement.GetAttribute("title");
                    boards.Add(new Board(bbs, name));
                }
                Category category = new Category(categoryElement.GetAttribute("title"), boards);
                Add(category);
            }

            Loaded = true;
        }

        public Category GetCategory(string bbs)
        {
            return this.First(category => category.Boards.Any(board => board.Bbs.Equals(bbs)));
        }
        public Board GetBoard(string bbs)
        {
            Category foundCategory = GetCategory(bbs);
            return foundCategory.Boards.First(board => board.Bbs.Equals(bbs));
        }
    }
}
