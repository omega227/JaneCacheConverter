using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace JaneCacheConverter
{
    public sealed class JaneCache
    {
        public JaneCache(string path, Jane2ch jane)
        {
            this.path = path;
            this.jane = jane;
            Load();
        }
        Jane2ch jane;
        private string path;
        public string ContentType { get; set; }
        public DateTime LastModified { get; set; }
        public string SourceUrl { get; set; }
        public string Referer { get; set; }
        public string FileName { get; set; }
        public Thread SourceThread { get; set; }
        public byte[] Data { get; private set; }
        public bool IsImage
        {
            get
            {
                return ContentType.ToLower().StartsWith("image");
            }
        }

        public void Load()
        {
            byte[] headerSize = new byte[4];
            byte[] header;
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                fs.Read(headerSize, 0, headerSize.Length);
                header = new byte[BitConverter.ToInt32(headerSize, 0)];

                fs.Read(header, 0, header.Length);

                using (MemoryStream memorystream = new MemoryStream())
                {
                    byte[] buffer = new byte[1024];
                    int count = -1;
                    while (count != 0)
                    {
                        count = fs.Read(buffer, 0, buffer.Length);
                        memorystream.Write(buffer, 0, count);
                    }

                    Data = memorystream.ToArray();
                }
            }

            string headerText = System.Text.Encoding.GetEncoding("shift_jis").GetString(header).Replace("\r\n", "\n");
            ContentType = Regex.Match(headerText, @"^ContentType=(.+)$", RegexOptions.Multiline).Groups[1].Value;
            if (IsImage)
            {
                string lastmodifiedText = Regex.Match(headerText, @"^LastModified=(.+)$", RegexOptions.Multiline).Groups[1].Value;
                DateTime lastModefied = DateTime.MinValue;
                DateTime.TryParse(lastmodifiedText, out lastModefied);
                LastModified = lastModefied;
                SourceUrl = Regex.Match(headerText, @"^URL=(.+)$", RegexOptions.Multiline).Groups[1].Value;
                string[] mimeType = ContentType.Split('/');
                string extention = mimeType.Length > 1 ? "." + mimeType[1] : "";
                FileName = FileNameUtility.GetSafeFileName(SourceUrl, extention);
                Referer = Regex.Match(headerText, @"^Referer=(.+)$", RegexOptions.Multiline).Groups[1].Value;
                SourceThread = jane.GetThread(Referer);
            }
        }
    }
}
