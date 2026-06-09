using System;

namespace WordsCards
{
    /// <summary>
    /// 單字物件：用來儲存單字、音標、解釋與音效路徑
    /// </summary>
    public class WordItem
    {
        // 屬性：儲存單字（例如：apple）
        public string Word { get; set; }

        // 屬性：儲存音標（例如：[ˈæpl]）
        public string Phonogram { get; set; }

        

        // 💡 新增屬性：儲存音效檔路徑（例如：mp3 檔案位置）
        public string SoundPath { get; set; }

        // 屬性：儲存中文解釋（例如：蘋果）
        public string Explain { get; set; }

        // 預設建構子
        public WordItem()
        {
           
        }

        // 建構子（更新版，把 SoundPath 也納入考慮）
        public WordItem(string word, string phonogram, string explain, string soundPath = "")
        {
            this.Word = word;
            this.Phonogram = phonogram;
            this.Explain = explain;
            this.SoundPath = soundPath;
        }
    }
}