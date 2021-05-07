using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 비트코인정보.Model;

namespace 비트코인정보
{
    public class SettingInfo
    {
        public List<CoinInfo> CoinList { get; set; }
        public Point Pos { get; set; }
        public Size Size { get; set; }
        public double Opacity { get; set; }
        public string Font { get; set; }
        public float FontSize { get; set; }
        public FontStyle FontStyle { get; set; }
        public Point NamePos { get; set; }
        public Point PricePos { get; set; }
        public Point ChangePos { get; set; }
        public int Interval { get; set; }
        public Color NameColor { get; set; }
        public Color WindowColor { get; set; }
        public Color UPColor { get; set; }     
        public Color KeepColor { get; set; }
        public Color DownColor { get; set; }
        public KeyInfo KeyInfo { get; set; }
        public bool IsMove { get; set; }
        public List<Notice> NoticeList { get; set; }
    }
}
