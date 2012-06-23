using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace JaneCacheConverter
{
    public static class Core
    {
        public static void ConvertAll(Jane2ch target, ConvertOption option, Action<int,string> callback)
        {
            target.ForEachImageCache((cache, parcent,processText) =>
                {
                    using (FileStream file = new FileStream(option.GetSavePath(cache), FileMode.Create))
                    {
                        file.Write(cache.Data, 0, cache.Data.Length);
                    }
                    callback(parcent,processText);
                });
        }
    }
}
