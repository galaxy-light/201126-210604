using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp;
using Newtonsoft.Json.Linq;
using System.IO;
using 비트코인정보.Util;
using 비트코인정보.Model;

namespace 비트코인정보
{
    public partial class MainForm : Form
    {
        WebSocket ws = new WebSocket(URL);
        const string URL = "wss://api.upbit.com/websocket/v1";
        string fileName = "setting.json";
        List<Label> nameLabels = new List<Label>();
        List<Label> priceLabels = new List<Label>();
        List<Label> changeLabels = new List<Label>();
        JArray rootArray;
        SettingInfo setting = new SettingInfo();
        Point mousePoint;
        Win32API.KeyModifiers modifier;
        bool isClosing = false;
        List<Timer> timerList = new List<Timer>();
        List<bool> isNoticeList = new List<bool>();

        public MainForm()
        {
            InitializeComponent();            
        }

        private void CreateLabel()
        {
            for (int i = 0; i < setting.CoinList.Count; i++)
            {
                Label label = new Label();
                nameLabels.Add(label);
                label.Text = setting.CoinList[i].Name;
                label.Location = new Point(setting.NamePos.X, i * setting.Interval + setting.NamePos.Y);
                label.Font = new Font(setting.Font, setting.FontSize, setting.FontStyle);
                label.ForeColor = setting.NameColor;
                label.AutoSize = true;
                Controls.Add(label);
            }
            for (int i = 0; i < setting.CoinList.Count; i++)
            {
                Label label = new Label();
                priceLabels.Add(label);
                label.Location = new Point(setting.PricePos.X, i * setting.Interval + setting.PricePos.Y);
                label.Font = new Font(setting.Font, setting.FontSize, setting.FontStyle);
                label.AutoSize = true;
                Controls.Add(label);
            }
            for (int i = 0; i < setting.CoinList.Count; i++)
            {
                Label label = new Label();
                changeLabels.Add(label);
                label.Location = new Point(setting.ChangePos.X, i * setting.Interval + setting.ChangePos.Y);
                label.Font = new Font(setting.Font, setting.FontSize, setting.FontStyle);
                label.AutoSize = true;
                Controls.Add(label);
            }
        }

        private void DeleteLabel()
        {
            for (int i = 0; i < nameLabels.Count; i++)
            {
                Controls.Remove(nameLabels[i]);
                Controls.Remove(priceLabels[i]);
                Controls.Remove(changeLabels[i]);
            }
            nameLabels.Clear();
            priceLabels.Clear();
            changeLabels.Clear();
        }

        private void SetInit()
        {      
            Location = setting.Pos;
            Size = setting.Size;
            Opacity = setting.Opacity;
            BackColor = setting.WindowColor;
            notifyIcon.Icon = Properties.Resources.upbitIcon;

            // 핫키 등록
            if (setting.KeyInfo.IsShift)
                modifier = (int)modifier + Win32API.KeyModifiers.Shift;
            if (setting.KeyInfo.IsCtrl)
                modifier = (int)modifier + Win32API.KeyModifiers.Control;
            if (setting.KeyInfo.IsAlt)
                modifier = (int)modifier + Win32API.KeyModifiers.Alt;
            Win32API.RegisterHotKey(Handle, 1, modifier, setting.KeyInfo.Key);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            setting.CoinList = new List<CoinInfo>();
            setting.NoticeList = new List<Notice>();
            Json.Load(fileName, ref setting);
            SetInit();

            ws.OnMessage += Ws_OnMessage;
            ws.OnClose += Ws_OnClose;
            ShowCoinInfo();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            isClosing = true;
            ws?.Close();
            Json.Save(fileName, setting);
        }

        private void Ws_OnClose(object sender, CloseEventArgs e)
        {
            if (!isClosing)
            {
                ws.Connect();
                ws.Send(rootArray.ToString());
                Console.WriteLine("연결 재요청");
            }
        }

        private void Ws_OnMessage(object sender, MessageEventArgs e)
        {
            string data = Encoding.UTF8.GetString(e.RawData);
            JObject root = JObject.Parse(data);

            for (int i = 0; i < setting.CoinList.Count; i++)
            {
                if (root["code"].Value<string>() == setting.CoinList[i].Code)
                {
                    Invoke(new Action(() =>
                    {
                        double temp = root["trade_price"].Value<double>();
                        if (temp < 100)
                            priceLabels[i].Text = $"{temp:N2}";
                        else
                            priceLabels[i].Text = $"{temp:N0}";

                        double changeRate = Math.Round(root["signed_change_rate"].Value<double>() * 100, 2);
                        string changeRateText = $"{changeRate}%";
                        if (changeRate > 0)
                            changeRateText = $"+{changeRateText}";
                        changeLabels[i].Text = changeRateText;
                        if (root["signed_change_rate"].Value<double>() > 0)
                        {
                            priceLabels[i].ForeColor = setting.UPColor;
                            changeLabels[i].ForeColor = setting.UPColor;
                        }
                        else if (root["signed_change_rate"].Value<double>() < 0)
                        {
                            priceLabels[i].ForeColor = setting.DownColor;
                            changeLabels[i].ForeColor = setting.DownColor;
                        }
                        else
                        {
                            priceLabels[i].ForeColor = setting.KeepColor;
                            changeLabels[i].ForeColor = setting.KeepColor;
                        }
                    }));
                }
            }
            for (int i = 0; i < setting.NoticeList.Count; i++)
            {
                if (root["code"].Value<string>() == setting.NoticeList[i].Code)
                {
                    if (isNoticeList[i])
                    {
                        double temp = root["trade_price"].Value<double>();
                        Console.WriteLine($"{setting.NoticeList[i].Code} : {temp}");
                        if (setting.NoticeList[i].Mode == Notice.UP)
                        {
                            if (temp >= setting.NoticeList[i].Price)
                            {
                                notifyIcon.BalloonTipTitle = setting.NoticeList[i].Name;
                                notifyIcon.BalloonTipText = $"{temp}원 입니다!";
                                notifyIcon.ShowBalloonTip(1000);
                            }
                        }
                        else
                        {
                            if (temp <= setting.NoticeList[i].Price)
                            {
                                notifyIcon.BalloonTipTitle = setting.NoticeList[i].Name;
                                notifyIcon.BalloonTipText = $"{temp}원 입니다!";
                                notifyIcon.ShowBalloonTip(1000);
                            }
                        }
                        isNoticeList[i] = false;
                    }
                }
            }
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            SettingForm form = new SettingForm(setting);
            if (form.ShowDialog() == DialogResult.OK)
                UseSetting();
            ShowCoinInfo();
            StartNotice();
            Json.Save(fileName, setting);
        }

        private void ShowCoinInfo()
        {
            DeleteLabel();
            if (setting.CoinList.Count > 0)
            {
                CreateLabel();

                rootArray = new JArray();
                rootArray.Add(new JObject(new JProperty("ticket", "UNIQUE_TICKET")));
                JArray array = new JArray();
                foreach (var item in setting.CoinList)
                {
                    array.Add(item.Code);
                }
                rootArray.Add(new JObject(new JProperty("type", "ticker"),
                    new JProperty("codes", array)));

                if (ws.ReadyState == WebSocketState.Open)
                {
                    ws.Close();
                }
                else
                {
                    try
                    {
                        ws.Connect();
                        ws.Send(rootArray.ToString());
                    }
                    catch (WebSocketException)
                    {
                        MessageBox.Show("서버에 연결할 수 없습니다!", "알림",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Application.Exit(); // 종료
                    }
                }
            }
        }

        private void UseSetting()
        {
            Location = setting.Pos;
            Size = setting.Size;
            Opacity = setting.Opacity;
            BackColor = setting.WindowColor;

            // 핫키 삭제 및 새로 생성
            modifier = Win32API.KeyModifiers.None;
            if (setting.KeyInfo.IsShift)
                modifier = (int)modifier + Win32API.KeyModifiers.Shift;
            if (setting.KeyInfo.IsCtrl)
                modifier = (int)modifier + Win32API.KeyModifiers.Control;
            if (setting.KeyInfo.IsAlt)
                modifier = (int)modifier + Win32API.KeyModifiers.Alt;
            Win32API.UnregisterHotKey(Handle, 1);
            Win32API.RegisterHotKey(Handle, 1, modifier, setting.KeyInfo.Key);
        }

        private void StartNotice()
        {
            timerList.Clear();
            foreach (var item in setting.NoticeList)
            {
                timerList.Add(new Timer());
                isNoticeList.Add(false);
            }
            for (int i = 0; i < setting.NoticeList.Count; i++)
            {
                timerList[i].Tick += timer_Tick;
                timerList[i].Interval = setting.NoticeList[i].Time * 1000;
                timerList[i].Start();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < timerList.Count; i++)
            {
                if (timerList[i] == sender as Timer)
                {
                    isNoticeList[i] = true;
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y); //현재 마우스 좌표 저장          
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (setting.IsMove)
            {
                if ((e.Button & MouseButtons.Left) == MouseButtons.Left) //마우스 왼쪽 클릭 시에만 실행
                {
                    Location = new Point(Left - (mousePoint.X - e.X), Top - (mousePoint.Y - e.Y));
                    setting.Pos = new Point(Location.X, Location.Y);
                }
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            btn_Exit.Location = new Point(ClientRectangle.Width - 66, ClientRectangle.Height - 32);
            btn_setting.Location = new Point(ClientRectangle.Width - 140, ClientRectangle.Height - 32);
        }

        protected override void WndProc(ref Message message)
        {
            switch (message.Msg)
            {
                case Win32API.WM_HOTKEY:
                    Keys key = (Keys)(((int)message.LParam >> 16) & 0xFFFF);
                    Win32API.KeyModifiers modifier_ = (Win32API.KeyModifiers)((int)message.LParam & 0xFFFF);
   
                    if (modifier_ == modifier && key == setting.KeyInfo.Key)
                    {
                        if (WindowState != FormWindowState.Minimized)
                            WindowState = FormWindowState.Minimized;
                        else
                            WindowState = FormWindowState.Normal;
                    }

                    break;
            }
            base.WndProc(ref message);
        }
    }
}
