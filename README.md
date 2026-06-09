# WordsCards 英文單字學習程式

一個基於 Windows Forms 的英文單字學習工具，支援音標顯示、字根解析、MP3 發音播放與自動播放功能。

---

## 功能特色

- 從 `.txt` 單字檔自動載入單字資料
- 顯示英文單字、音標、字根解析與中文解釋
- 透過 Windows Media Player 播放 MP3 發音音效
- 支援手動逐字瀏覽與自動連續播放模式
- 鍵盤快捷鍵操作（Enter / Space）

---

## 專案結構

```
WordsCards/
├── frmWordCards.cs        # 主視窗邏輯
├── WordItem.cs            # 單字資料物件
├── WordCollection.cs      # 單字清單集合（載入與解析）
├── WordCards.txt          # 單字資料檔
└── Sound/
    └── A/
        ├── abacus.mp3
        ├── abandon.mp3
        └── ...            # 各單字對應 MP3 音效檔
```

---

## 單字檔格式

`WordCards.txt` 使用 **Tab 分隔**，每行格式如下：

```
單字	音標	音效路徑	字根解析	中文解釋	補充
```

範例：

```
abacus	ˋæbəkəs	Sound\A\abacus.mp3	<aba-=abax-:一種計算工具>+<-us: calculus 小圓石>	一種利用小圓石幫助計算的工具	補充4
abandon	əˋbændən	Sound\A\abandon.mp3	<ab-:away>+<-band:bind綁>	ban 禁令	把自己都放棄掉
abase	əˋbes	Sound\A\abase.mp3	<base:基礎>		
```

> 字根解析與中文解釋欄位可為空白，程式會自動略過。

---

## 操作說明

### 手動模式

| 操作 | 說明 |
|------|------|
| 點選清單項目 | 顯示單字資訊並播放發音 |
| `Enter` | 跳至下一個單字並播放 |
| `Space` | 重複播放目前單字 |

### 自動播放模式

- 點擊 **Play** 按鈕開始自動播放，依 Timer 間隔自動切換至下一個單字
- 點擊 **Stop** 按鈕停止自動播放

---

## 環境需求

- Windows 作業系統
- .NET Framework（Windows Forms）
- Windows Media Player（WMPLib）
- Visual Studio（建議 2019 以上）

---

## 安裝與執行

1. 複製專案到本機
2. 確認 `WordCards.txt` 位於執行檔同層目錄
3. 確認 `Sound\A\` 資料夾內有對應的 MP3 音效檔
4. 以 Visual Studio 開啟並建置專案，執行即可

---

## 注意事項

- 音效檔路徑直接對應 `WordCards.txt` 第三欄，檔名需與資料一致（包含底線、大小寫）
- 單字檔編碼為 **UTF-8**
