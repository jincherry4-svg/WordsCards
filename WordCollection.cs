using System;
using System.Collections.Generic;

namespace WordsCards
{
    /// <summary>
    /// 單字清單集合
    /// </summary>
    public class WordCollection : List<WordItem>
    {
        /// <summary>
        /// 從字串陣列（讀取自文字檔的每一行）載入單字資料
        /// </summary>
        /// <param name="lines">文字檔的所有行</param>
        public void LoadFromStringArray(string[] lines)
        {
            // 先清空原本可能存在的舊資料
            this.Clear();

            foreach (string line in lines)
            {
                // 如果是空行，就跳過不處理
                if (string.IsNullOrWhiteSpace(line)) continue;

                // 根據你的文字檔格式進行切割。
                // 這裡假設欄位之間是用「Tab 鍵 (\t)」或「逗號」隔開
                // 如果你的文字檔是用空格，可以把下面的 '\t' 改成 ',' 或 ' '
                string[] parts = line.Split('\t');

                if (parts.Length >= 3)
                {
                    WordItem item = new WordItem();
                    item.Word = parts[0].Trim();
                    item.Phonogram = parts[1].Trim();
                    item.SoundPath = parts[2].Trim();

                    string etymology = parts.Length > 3 ? parts[3].Trim() : "";
                    string meaning = parts.Length > 4 ? parts[4].Trim() : "";

                    if (etymology != "" && meaning != "")
                        item.Explain = etymology + Environment.NewLine + meaning;
                    else if (etymology != "")
                        item.Explain = etymology;
                    else if (meaning != "")
                        item.Explain = meaning;
                    else
                        item.Explain = "";

                    this.Add(item);
                }
            }
        }
    }
}