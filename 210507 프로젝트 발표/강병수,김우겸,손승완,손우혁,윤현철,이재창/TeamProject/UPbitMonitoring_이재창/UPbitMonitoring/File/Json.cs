using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 비트코인정보.Model;

namespace 비트코인정보
{
    static class Json
    {
        public static void Save(string fileName, SettingInfo setting)
        {
            JObject root = new JObject();
            JArray coinArray = new JArray();
            //JArray noticeArray = new JArray();
            JObject jSetting = new JObject
            {               
                new JProperty("Pos", new JObject
                { 
                    new JProperty("X", new JValue(setting.Pos.X)),
                    new JProperty("Y", new JValue(setting.Pos.Y))
                }),
                new JProperty("Size", new JObject
                {
                    new JProperty("Width", new JValue(setting.Size.Width)),
                    new JProperty("Height", new JValue(setting.Size.Height))
                }),
                new JProperty("Opacity", new JValue(setting.Opacity)),
                new JProperty("Font", new JValue(setting.Font)),
                new JProperty("FontSize", new JValue(setting.FontSize)),
                new JProperty("FontStyle", new JValue(setting.FontStyle)),
                new JProperty("NamePos", new JObject
                {
                    new JProperty("X", new JValue(setting.NamePos.X)),
                    new JProperty("Y", new JValue(setting.NamePos.Y))
                }),
                new JProperty("PricePos", new JObject
                {
                    new JProperty("X", new JValue(setting.PricePos.X)),
                    new JProperty("Y", new JValue(setting.PricePos.Y))
                }),
                new JProperty("ChangePos", new JObject
                {
                    new JProperty("X", new JValue(setting.ChangePos.X)),
                    new JProperty("Y", new JValue(setting.ChangePos.Y))
                }),
                new JProperty("KeyInfo", new JObject
                {
                    new JProperty("Key", new JValue(setting.KeyInfo.Key)),
                    new JProperty("IsShift", new JValue(setting.KeyInfo.IsShift)),
                    new JProperty("IsCtrl", new JValue(setting.KeyInfo.IsCtrl)),
                    new JProperty("IsAlt", new JValue(setting.KeyInfo.IsAlt)),
                }),
                new JProperty("Interval", new JValue(setting.Interval)),
                new JProperty("NameColor", new JValue(((uint)setting.NameColor.ToArgb()).ToString("X"))),
                new JProperty("UPColor", new JValue(((uint)setting.UPColor.ToArgb()).ToString("X"))),
                new JProperty("KeepColor", new JValue(((uint)setting.KeepColor.ToArgb()).ToString("X"))),
                new JProperty("DownColor", new JValue(((uint)setting.DownColor.ToArgb()).ToString("X"))),
                new JProperty("WindowColor", new JValue(((uint)setting.WindowColor.ToArgb()).ToString("X"))),
                new JProperty("IsMove", new JValue(setting.IsMove)),
                new JProperty("CoinList", coinArray)
                //new JProperty("NoticeList", coinArray)
            };
            root.Add(new JProperty("Setting", jSetting));
            foreach (var item in setting.CoinList)
            {
                coinArray.Add(new JObject(
                    new JProperty("Name", item.Name),
                    new JProperty("Code", item.Code)));
            }
            //foreach (var item in setting.NoticeList)
            //{
            //    noticeArray.Add(new JObject(
            //        new JProperty("Name", item.Name),
            //        new JProperty("Code", item.Code),
            //        new JProperty("Price", item.Price),
            //        new JProperty("Time", item.Time)));
            //}
            File.WriteAllText(fileName, root.ToString());
        }

        public static void Load(string fileName, ref SettingInfo setting)
        {
            try
            {
                JObject root = JObject.Parse(File.ReadAllText(fileName));
                foreach (var item in root["Setting"]["CoinList"])
                {
                    setting.CoinList.Add(new CoinInfo
                    {
                        Name = item["Name"].Value<string>(),
                        Code = item["Code"].Value<string>()
                    });
                }
                //foreach (var item in root["Setting"]["NoticeList"])
                //{
                //    setting.NoticeList.Add(new Notice
                //    {
                //        Name = item["Name"].Value<string>(),
                //        Code = item["Code"].Value<string>(),
                //        Price = item["Price"].Value<double>(),
                //        Time = item["Time"].Value<string>()
                //    });
                //}

                JToken jSetting = root["Setting"];
                setting.Pos = new Point(jSetting["Pos"]["X"].Value<int>(),
                    jSetting["Pos"]["Y"].Value<int>());
                setting.Size = new Size(jSetting["Size"]["Width"].Value<int>(),
                    jSetting["Size"]["Height"].Value<int>());
                setting.Opacity = jSetting["Opacity"].Value<double>();
                setting.Font = jSetting["Font"].Value<string>();
                setting.FontSize = jSetting["FontSize"].Value<float>();
                setting.FontStyle = (FontStyle)jSetting["FontStyle"].Value<int>();
                setting.NamePos = new Point(jSetting["NamePos"]["X"].Value<int>(),
                    jSetting["NamePos"]["Y"].Value<int>());
                setting.PricePos = new Point(jSetting["PricePos"]["X"].Value<int>(),
                    jSetting["PricePos"]["Y"].Value<int>());
                setting.ChangePos = new Point(jSetting["ChangePos"]["X"].Value<int>(),
                    jSetting["ChangePos"]["Y"].Value<int>());
                setting.KeyInfo = new KeyInfo
                {
                    Key = (Keys)jSetting["KeyInfo"]["Key"].Value<int>(),
                    IsShift = jSetting["KeyInfo"]["IsShift"].Value<bool>(),
                    IsCtrl = jSetting["KeyInfo"]["IsCtrl"].Value<bool>(),
                    IsAlt = jSetting["KeyInfo"]["IsAlt"].Value<bool>(),
                };
                setting.Interval = jSetting["Interval"].Value<int>();
                setting.NameColor = Color.FromArgb(Convert.ToInt32(jSetting["NameColor"].Value<string>(), 16));
                setting.UPColor = Color.FromArgb(Convert.ToInt32(jSetting["UPColor"].Value<string>(), 16));
                setting.KeepColor = Color.FromArgb(Convert.ToInt32(jSetting["KeepColor"].Value<string>(), 16));
                setting.DownColor = Color.FromArgb(Convert.ToInt32(jSetting["DownColor"].Value<string>(), 16));
                setting.WindowColor = Color.FromArgb(Convert.ToInt32(jSetting["WindowColor"].Value<string>(), 16));
                setting.IsMove = jSetting["IsMove"].Value<bool>();
            }
            catch (Exception)
            {
                MessageBox.Show("파일이 없거나 문제가 있어 새로 생성합니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                setting = new SettingInfo
                {
                    CoinList = new List<CoinInfo>(),
                    Pos = new Point(DefaultValue.X, DefaultValue.Y),
                    Size = new Size(DefaultValue.Width, DefaultValue.Height),
                    Opacity = DefaultValue.Opacity,
                    Font = DefaultValue.Font,
                    FontSize = DefaultValue.FontSize,
                    FontStyle = DefaultValue.FontStyle,
                    NamePos = new Point(DefaultValue.NameX, DefaultValue.NameY),
                    PricePos = new Point(DefaultValue.PriceX, DefaultValue.PriceY),
                    ChangePos = new Point(DefaultValue.ChangeX, DefaultValue.ChangeY),
                    Interval = DefaultValue.Interval,
                    NameColor = DefaultValue.NameColor,
                    UPColor = DefaultValue.UPColor,
                    KeepColor = DefaultValue.KeepColor,
                    DownColor = DefaultValue.DownColor,
                    WindowColor = DefaultValue.WindowColor,
                    KeyInfo = DefaultValue.KeyInfo,
                    IsMove = DefaultValue.IsMove,
                    NoticeList = new List<Notice>()
                };
                Save("setting.json", setting);
            }
        }
    }
}
