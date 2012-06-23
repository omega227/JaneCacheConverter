using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace JaneCacheConverter
{
    public sealed class Jane2ch
    {
        public Jane2ch()
        {
            Threads = new ThreadCollection();
            Categories = new CategoryCollection();
        }

        public Jane2ch(string folder)
            : this()
        {
            this.folder = folder;
        }
        private string folder;

        string viewCacheFolder;
        public string ViewCacheFolder
        {
            get
            {
                if (viewCacheFolder == null)
                {
                    string inipath = Path.Combine(folder, "ImageView.ini");
                    string defaultFolder = Path.Combine(folder, "VwCache");
                    if (!File.Exists(inipath))
                    {
                        return defaultFolder;
                    }
                    StringBuilder sb = new StringBuilder(1024);
                    NativeMethod.GetPrivateProfileString("Cache", "CachePath", defaultFolder, sb, (uint)sb.Capacity, inipath);
                    viewCacheFolder = sb.Length > 0 ? sb.ToString() : defaultFolder;
                }
                return viewCacheFolder;
            }
        }

        private string logFolder;
        public string LogFolder
        {
            get
            {
                if (logFolder == null)
                {
                    string inipath = Path.Combine(folder, "Jane2ch.ini");
                    string defaultFolder = Path.Combine(folder, @"Logs\2ch");
                    if (!File.Exists(inipath))
                    {
                        return defaultFolder;
                    }
                    StringBuilder sb = new StringBuilder(1024);
                    NativeMethod.GetPrivateProfileString("PATH", "LogBasePath", defaultFolder, sb, (uint)sb.Capacity, inipath);
                    logFolder = sb.Length > 0 ? sb.ToString() : defaultFolder;
                }
                return logFolder;
            }
        }

        public string GetLogFilePath(Thread thread)
        {
            return Path.Combine(LogFolder, thread.Category, thread.Board, thread.Url.Key + ".idx");
        }

        public CategoryCollection Categories { get; private set; }
        public ThreadCollection Threads { get; private set; }

        public Thread GetThread(string url)
        {
            Url2ch url2ch = new Url2ch(url);
            Thread foundThread = Threads.FirstOrDefault(thread => thread.Url.Equals(url));
            if (foundThread != null)
            {
                return foundThread;
            }
            else
            {
                Thread newThread = new Thread(url, this);
                Threads.Add(newThread);
                return newThread;
            }
        }

        public string[] GetCachePathes()
        {
            return Directory.GetFiles(ViewCacheFolder, "*.vch");
        }

        public void ForEachImageCache(Action<JaneCache, int, string> action)
        {
            string[] cachePathes = GetCachePathes();
            for (int i = 0; i < cachePathes.Length; i++)
            {
                JaneCache cache = new JaneCache(cachePathes[i], this);
                if (cache.IsImage)
                {
                    int parcent = 100 * i / cachePathes.Length;
                    string processText = string.Format("変換中... {0}/{1}", cache.SourceThread.Title, cache.FileName);
                    action(cache, parcent, processText);
                }
            }
        }
    }
}
