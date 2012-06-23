using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace JaneCacheConverter
{
    public sealed class Thread
    {
        public Thread(string url, Jane2ch jane)
        {
            Url = new Url2ch(url);
            this.jane = jane;
        }

        public static string[] FormatNamePairs = 
        {   TitleFormat, "スレッドタイトル",
            DirectorySeparateFormat, "ディレクトリー区切り(\\)",
            CategoryFormat, "カテゴリー", 
            BoardFormat, "板",
            SinceFormat, "スレッド作成日", 
            KeyFormat, "スレッド固有の番号",};

        public const string TitleFormat = "%title%";
        public const string CategoryFormat = "%category%";
        public const string BoardFormat = "%board%";
        public const string KeyFormat = "%key%";
        public const string SinceFormat = "%since%";
        public const string DirectorySeparateFormat = "%_%";
        public const string SinceTextFormat = "yyyy/MM/dd";

        private Jane2ch jane;
        public Url2ch Url { get; private set; }
        public string Category
        {
            get
            {
                return jane.Categories.GetCategory(Url.Bbs).Name;
            }
        }

        public string Board
        {
            get
            {
                return jane.Categories.GetBoard(Url.Bbs).Name;
            }
        }
        private string title;
        public string Title
        {
            get
            {
                if (title == null)
                {
                    string logPath = jane.GetLogFilePath(this);
                    if (File.Exists(logPath))
                    {
                        using (StreamReader reader = new StreamReader(logPath, Encoding.GetEncoding("shift_jis")))
                        {
                            title = reader.ReadLine();
                        }
                    }
                }
                return title;
            }
        }

        public DateTime Since
        {
            get
            {
                DateTime time = new DateTime(1970, 1, 1);
                int seconds;
                if (int.TryParse(Url.Key, out seconds))
                {
                    time = time.AddSeconds((double)seconds);
                }
                return time;
            }
        }

        public string Format(string text)
        {
            string replacedText = text.Replace(TitleFormat, Title);
            replacedText = replacedText.Replace(BoardFormat, Board);
            replacedText = replacedText.Replace(KeyFormat, Url.Key);
            //アクセスにコストかかるのでチェック
            if (text.Contains(CategoryFormat))
            {
                replacedText = replacedText.Replace(CategoryFormat, Category);
            }
            if (text.Contains(SinceFormat))
            {
                replacedText = replacedText.Replace(SinceFormat, Since.ToString(SinceTextFormat));
            }

            return replacedText;
        }

        public string FormatDirectorySeparator(string safePathFormatWithOutDirectorySeparator)
        {
            return safePathFormatWithOutDirectorySeparator.Replace(DirectorySeparateFormat, Path.DirectorySeparatorChar.ToString());
        }
    }

    public sealed class Url2ch
    {
        public Url2ch(string url)
        {
            Match urlMatch = Regex.Match(url, @"http://(.+)/test/read\.cgi/(.+)/(\d+)");
            Bbs = urlMatch.Groups[2].Value;
            Key = urlMatch.Groups[3].Value;
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is Url2ch)
            {
                Url2ch target = (Url2ch)obj;
                return (Bbs + Key).Equals(target.Bbs + target.Key);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (Bbs + Key).GetHashCode();
        }

        public string Url { get; set; }
        public string Bbs { get; set; }
        public string Key { get; set; }
    }
}
