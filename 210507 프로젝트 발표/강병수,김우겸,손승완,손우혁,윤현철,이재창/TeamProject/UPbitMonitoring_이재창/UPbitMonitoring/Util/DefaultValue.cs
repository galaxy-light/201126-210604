using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 비트코인정보.Model;

namespace 비트코인정보
{
    class DefaultValue
    {
        public static readonly int X = Screen.PrimaryScreen.Bounds.Width - 396;
        public static readonly int Y = 5;
        public static readonly int Width = 390;
        public static readonly int Height = 320;
        public static readonly double Opacity = 0.85;
        public static readonly string Font = "맑은 고딕";
        public static readonly float FontSize = 13;
        public static readonly FontStyle FontStyle = FontStyle.Bold;
        public static readonly int NameX = 5;
        public static readonly int NameY = 5;
        public static readonly int PriceX = 145;
        public static readonly int PriceY = 4;
        public static readonly int ChangeX = 285;
        public static readonly int ChangeY = 4;
        public static readonly int Interval = 26;
        public static readonly Color NameColor = Color.FromArgb(32, 255, 32);
        public static readonly Color WindowColor = Color.FromArgb(16, 16, 16);
        public static readonly Color UPColor = Color.FromArgb(255, 32, 32);
        public static readonly Color KeepColor = Color.White;
        public static readonly Color DownColor = Color.FromArgb(0, 128, 255);
        public static readonly KeyInfo KeyInfo = new KeyInfo { Key = Keys.F4 };
        public static readonly bool IsMove = true;
    }
}
