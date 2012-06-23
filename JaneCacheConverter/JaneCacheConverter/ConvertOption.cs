using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace JaneCacheConverter
{
    public sealed class ConvertOption
    {
        public ConvertOption()
        {
            FolderFormat = Thread.TitleFormat;
            ImageSaveMode = JaneCacheConverter.ImageSaveMode.OverWrite;
        }
        public string SaveFolder { get; set; }
        public string FolderFormat { get; set; }
        public ImageSaveMode ImageSaveMode { get; set; }

        public string GetSavePath(JaneCache target)
        {
            string folderName = target.SourceThread.Format(FolderFormat);
            string safeFolderName = null;
            try
            {
                safeFolderName = FileNameUtility.EscapeFileName(folderName);
                safeFolderName = target.SourceThread.FormatDirectorySeparator(safeFolderName);
            }
            catch (ArgumentException)
            {
                safeFolderName = "[不明なスレッド]";
            }
            string lastSaveFolder = Path.Combine(SaveFolder, safeFolderName);
            Directory.CreateDirectory(lastSaveFolder);
            string savePath = Path.Combine(lastSaveFolder, target.FileName);
            string lastSavePath = null;
            if (ImageSaveMode == JaneCacheConverter.ImageSaveMode.ChangeName
                && File.Exists(savePath))
            {
                lastSavePath = FileNameUtility.Rename(savePath);
            }
            else
            {
                lastSavePath = savePath;
            }
            return lastSavePath;
        }
    }

    public enum ImageSaveMode
    {
        None,
        OverWrite,
        ChangeName
    }
}
