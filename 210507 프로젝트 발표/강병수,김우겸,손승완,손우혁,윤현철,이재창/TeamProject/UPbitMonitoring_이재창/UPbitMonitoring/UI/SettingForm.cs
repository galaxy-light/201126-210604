using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using 비트코인정보.Model;
using 비트코인정보.Util;

namespace 비트코인정보
{
    public partial class SettingForm : Form
    {
        public SettingInfo Setting { get; set; }
        private Point mousePoint;
        const string URL = "https://api.upbit.com/v1/market/all";
        private List<CoinInfo> RestCoinList = new List<CoinInfo>();
        public KeyInfo KeyInfo { get; set; }
        public List<CoinInfo> coinList = new List<CoinInfo>();
        public List<Notice> noticeList = new List<Notice>();

        public SettingForm(SettingInfo setting)
        {
            InitializeComponent();
            Setting = setting;
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            GetCoinData();
            if (Setting.CoinList.Count > 0)
            {
                coinList = new List<CoinInfo>(Setting.CoinList);
                gridView_coinInfo.DataSource = coinList;
            }         
            if (Setting.NoticeList.Count > 0)
            {
                noticeList = new List<Notice>(Setting.NoticeList);
                gridView_notice.DataSource = noticeList;
            }
            tb_x.Text = Setting.Pos.X.ToString();
            tb_y.Text = Setting.Pos.Y.ToString();
            tb_width.Text = Setting.Size.Width.ToString();
            tb_height.Text = Setting.Size.Height.ToString();
            tb_opacity.Text = (Setting.Opacity * 100).ToString();
            combo_kind.SelectedIndex = 0;
            combo_noticeKind.SelectedIndex = 0;
            tb_fontSize.Text = Setting.FontSize.ToString();
            tb_nameX.Text = Setting.NamePos.X.ToString();
            tb_nameY.Text = Setting.NamePos.Y.ToString();
            tb_priceX.Text = Setting.PricePos.X.ToString();
            tb_priceY.Text = Setting.PricePos.Y.ToString();
            tb_changeX.Text = Setting.ChangePos.X.ToString();
            tb_changeY.Text = Setting.ChangePos.Y.ToString();
            tb_interval.Text = Setting.Interval.ToString();
            btn_nameColor.BackColor = Setting.NameColor;
            btn_upColor.BackColor = Setting.UPColor;
            btn_keepColor.BackColor = Setting.KeepColor;
            btn_downColor.BackColor = Setting.DownColor;
            btn_windowColor.BackColor = Setting.WindowColor;

            if (Setting.FontStyle == FontStyle.Regular)
                rbtn_nomal.Checked = true;
            else
                rbtn_bold.Checked = true;

            btn_nameColor.Click += btn_colors_Click;
            btn_upColor.Click += btn_colors_Click;
            btn_keepColor.Click += btn_colors_Click;
            btn_downColor.Click += btn_colors_Click;
            btn_windowColor.Click += btn_colors_Click;

            foreach (var item in FontFamily.Families)
            {
                combo_font.Items.Add(item.Name);
            }
            for (int i = 0; i < FontFamily.Families.Length; i++)
            {
                if (FontFamily.Families[i].Name == Setting.Font)
                {
                    combo_font.SelectedIndex = i;
                    break;
                }
            }
            foreach (var item in KeyData.Keys)
            {
                combo_showOrHide.Items.Add(item);
            }
            combo_showOrHide.SelectedItem = Setting.KeyInfo.Key;
            ckb_shift.Checked = Setting.KeyInfo.IsShift;
            ckb_ctrl.Checked = Setting.KeyInfo.IsCtrl;
            ckb_alt.Checked = Setting.KeyInfo.IsAlt;
            if (Setting.IsMove)
                rbtn_move.Checked = true;
            else
                rbtn_fixing.Checked = true;
            tb_h.Text = 0.ToString();
            tb_m.Text = 0.ToString();
            tb_s.Text = 1.ToString();
            tb_noticePrice.Text = 0.ToString();
            combo_noticeMode.SelectedIndex = 0;
        }

        private void GetCoinData()
        {
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            string json = wc.DownloadString(URL);
            JArray rootArray = JArray.Parse(json);
            foreach (var item in rootArray)
            {
                RestCoinList.Add(new CoinInfo
                {
                    Code = item["market"].Value<string>(),
                    Name = item["korean_name"].Value<string>()
                });
            }
        }

        private void btn_itemAdd_Click(object sender, EventArgs e)
        {
            if (tb_name.Text != string.Empty && tb_code.Text != string.Empty)
            {
                coinList.Add(new CoinInfo
                {
                    Name = tb_name.Text,
                    Code = tb_code.Text
                });
                gridView_coinInfo.DataSource = null;
                gridView_coinInfo.DataSource = coinList;
                tb_name.Text = string.Empty;
                tb_code.Text = string.Empty;
            }
        }

        private void btn_complete_Click(object sender, EventArgs e)
        {
            try
            {
                Setting.Pos = new Point(Convert.ToInt32(tb_x.Text), Convert.ToInt32(tb_y.Text));
                Setting.Size = new Size(Convert.ToInt32(tb_width.Text), Convert.ToInt32(tb_height.Text));
                Setting.Opacity = Convert.ToDouble(tb_opacity.Text) / 100;
                Setting.Font = combo_font.SelectedItem.ToString();
                Setting.FontSize = Convert.ToSingle(tb_fontSize.Text);              
                Setting.NamePos = new Point(Convert.ToInt32(tb_nameX.Text), Convert.ToInt32(tb_nameY.Text));
                Setting.PricePos = new Point(Convert.ToInt32(tb_priceX.Text), Convert.ToInt32(tb_priceY.Text));
                Setting.ChangePos = new Point(Convert.ToInt32(tb_changeX.Text), Convert.ToInt32(tb_changeY.Text));
                Setting.Interval = Convert.ToInt32(tb_interval.Text);
                Setting.NameColor = btn_nameColor.BackColor;
                Setting.UPColor = btn_upColor.BackColor;
                Setting.KeepColor = btn_keepColor.BackColor;
                Setting.DownColor = btn_downColor.BackColor;
                Setting.WindowColor = btn_windowColor.BackColor;
                if (rbtn_nomal.Checked)
                    Setting.FontStyle = FontStyle.Regular;
                else
                    Setting.FontStyle = FontStyle.Bold;
                Setting.KeyInfo = new KeyInfo
                {
                    Key = (Keys)combo_showOrHide.SelectedItem,
                    IsShift = ckb_shift.Checked,
                    IsCtrl = ckb_ctrl.Checked,
                    IsAlt = ckb_alt.Checked
                };
                Setting.IsMove = rbtn_move.Checked;
                Setting.CoinList = coinList;
                Setting.NoticeList = noticeList;
            }
            catch (Exception)
            {
                MessageBox.Show("설정값을 제대로 입력해주세요!", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void btn_itemDel_Click(object sender, EventArgs e)
        {
            var rows = gridView_coinInfo.SelectedRows;
            if (rows.Count > 0)
            {
                for (int i = 0; i < rows.Count; i++)
                {
                    coinList.RemoveAt(rows[i].Index);
                }
                gridView_coinInfo.DataSource = null;
                gridView_coinInfo.DataSource = coinList;
            }           
        }

        private void gridView_coinInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (coinList.Count > 0)
            {
                tb_name.Text = gridView_coinInfo.SelectedRows[0].Cells[0].Value.ToString();
                tb_code.Text = gridView_coinInfo.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void btn_itemUdt_Click(object sender, EventArgs e)
        {
            var rows = gridView_coinInfo.SelectedRows;
            if (rows.Count > 0)
            {
                coinList[rows[0].Index].Name = tb_name.Text;
                coinList[rows[0].Index].Code = tb_code.Text;
                gridView_coinInfo.DataSource = null;
                gridView_coinInfo.DataSource = coinList;
            }
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            var rows = gridView_coinInfo.SelectedRows;
            if (rows.Count > 0)
            {
                int index = rows[0].Index;
                if (index > 0)
                {
                    var temp = coinList[index - 1];
                    coinList[index - 1] = coinList[index];
                    coinList[index] = temp;
                    gridView_coinInfo.CurrentCell = gridView_coinInfo.Rows[index - 1].Cells[0];
                    gridView_coinInfo.DataSource = null;
                    gridView_coinInfo.DataSource = coinList;
                }
            }
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            var rows = gridView_coinInfo.SelectedRows;
            if (rows.Count > 0)
            {
                int index = rows[0].Index;
                if (index < gridView_coinInfo.Rows.Count - 1)
                {
                    var temp = coinList[index + 1];
                    coinList[index + 1] = coinList[index];
                    coinList[index] = temp;
                    gridView_coinInfo.CurrentCell = gridView_coinInfo.Rows[index + 1].Cells[0];
                    gridView_coinInfo.DataSource = null;
                    gridView_coinInfo.DataSource = coinList;
                }
            }
        }

        private void lbl_title_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y); //현재 마우스 좌표 저장
        }

        private void lbl_title_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left) //마우스 왼쪽 클릭 시에만 실행
            {
                Location = new Point(Left - (mousePoint.X - e.X), Top - (mousePoint.Y - e.Y));
            }
        }

        private void ckb_default_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_default.Checked)
            {
                SetDefaultValue();
                foreach (var item in tabPage2.Controls)
                {
                    if (item is GroupBox)
                    {
                        GroupBox gb = item as GroupBox;
                        foreach (var item1 in gb.Controls)
                        {
                            if (item1 is TextBox)
                            {
                                TextBox tb = item1 as TextBox;
                                tb.Enabled = false;
                            }
                            else if (item1 is Button)
                            {
                                Button btn = item1 as Button;
                                btn.Enabled = false;
                            }
                        }
                    }
                }
                combo_font.Enabled = false;
                rbtn_nomal.Enabled = false;
                rbtn_bold.Enabled = false;
                rbtn_move.Enabled = false;
                rbtn_fixing.Enabled = false;
            }
            else
            {
                foreach (var item in tabPage2.Controls)
                {
                    if (item is GroupBox)
                    {
                        GroupBox gb = item as GroupBox;
                        foreach (var item1 in gb.Controls)
                        {
                            if (item1 is TextBox)
                            {
                                TextBox tb = item1 as TextBox;
                                tb.Enabled = true;
                            }
                            else if (item1 is Button)
                            {
                                Button btn = item1 as Button;
                                btn.Enabled = true;
                            }
                        }
                    }
                }
                combo_font.Enabled = true;
                rbtn_nomal.Enabled = true;
                rbtn_bold.Enabled = true;
                rbtn_move.Enabled = true;
                rbtn_fixing.Enabled = true;
            }
        }

        private void SetDefaultValue()
        {
            tb_x.Text = DefaultValue.X.ToString();
            tb_y.Text = DefaultValue.Y.ToString();
            tb_width.Text = DefaultValue.Width.ToString();
            tb_height.Text = DefaultValue.Height.ToString();
            tb_opacity.Text = (DefaultValue.Opacity * 100).ToString();
            tb_fontSize.Text = DefaultValue.FontSize.ToString();
            tb_nameX.Text = DefaultValue.NameX.ToString();
            tb_nameY.Text = DefaultValue.NameY.ToString();
            tb_priceX.Text = DefaultValue.PriceX.ToString();
            tb_priceY.Text = DefaultValue.PriceY.ToString();
            tb_changeX.Text = DefaultValue.ChangeX.ToString();
            tb_changeY.Text = DefaultValue.ChangeY.ToString();
            tb_interval.Text = DefaultValue.Interval.ToString();
            btn_nameColor.BackColor = DefaultValue.NameColor;
            btn_upColor.BackColor = DefaultValue.UPColor;
            btn_keepColor.BackColor = DefaultValue.KeepColor;
            btn_downColor.BackColor = DefaultValue.DownColor;
            btn_windowColor.BackColor = DefaultValue.WindowColor;
            rbtn_bold.Checked = true;
            for (int i = 0; i < FontFamily.Families.Length; i++)
            {
                if (FontFamily.Families[i].Name == DefaultValue.Font)
                {
                    combo_font.SelectedIndex = i;
                    break;
                }
            }
            combo_showOrHide.SelectedItem = DefaultValue.KeyInfo.Key;
            ckb_shift.Checked = false;
            ckb_ctrl.Checked = false;
            ckb_alt.Checked = false;
            rbtn_move.Checked = true;
        }

        private void combo_coinList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] strs = combo_coinList.SelectedItem.ToString().Split('/');
            tb_name.Text = strs[0].Trim();
            tb_code.Text = strs[1].Trim();
        }

        private void combo_kind_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_coinList.Items.Clear();
            foreach (var item in RestCoinList)
            {
                if (item.Code.IndexOf(combo_kind.SelectedItem.ToString()) >= 0)
                {
                    combo_coinList.Items.Add($"{item.Name} / {item.Code}");
                }
            }          
        }

        private void gridView_coinInfo_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            GridViewRowPostPaint(e);
        }

        private void btn_colors_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {               
                btn.BackColor = colorDialog.Color;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btn_noticeAdd_Click(object sender, EventArgs e)
        {         
            if (tb_noticeName.Text == string.Empty || tb_noticeCode.Text == string.Empty ||
                tb_noticePrice.Text == string.Empty || tb_h.Text == string.Empty ||
                tb_m.Text == string.Empty || tb_s.Text == string.Empty)
            {
                MessageBox.Show("값을 전부 입력해주세요!", "알림",
                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int time = GetSecond(Convert.ToInt32(tb_h.Text),
                    Convert.ToInt32(tb_m.Text), Convert.ToInt32(tb_s.Text));
                if (time < 1)
                {
                    MessageBox.Show("주기는 1초 이상만 가능합니다!", "알림",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                noticeList.Add(new Notice
                {
                    Name = tb_noticeName.Text,
                    Code = tb_noticeCode.Text,
                    Price = Convert.ToDouble(tb_noticePrice.Text),
                    Time = time,
                    Format = GetTimeFormat(time),
                    Mode = combo_noticeMode.SelectedIndex == 0 ? Notice.UP : Notice.Down
                });
            }
            catch (Exception)
            {
                MessageBox.Show("값을 제대로 입력해주세요!", "알림",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            gridView_notice.DataSource = null;
            gridView_notice.DataSource = noticeList;
        }

        private int GetSecond(int h, int m, int s)
        {
            int second = h * 3600 + m * 60 + s;
            return second;
        }

        private string GetTimeFormat(int second)
        {
            int h = second / 3600;
            int m = second / 60 % 60;
            int s = second % 60;

            string format = string.Empty;
            if (h > 0)
                format += $"{h}시간 ";
            if (m > 0)
                format += $"{m}분 ";
            if (s > 0)
                format += $"{s}초";
            return format;
        }

        private void btn_noticeDel_Click(object sender, EventArgs e)
        {
            var rows = gridView_notice.SelectedRows;
            if (rows.Count > 0)
            {
                for (int i = 0; i < rows.Count; i++)
                {
                    noticeList.RemoveAt(rows[i].Index);
                }
                gridView_notice.DataSource = null;
                gridView_notice.DataSource = noticeList;
            }
        }

        private void btn_noticeUdt_Click(object sender, EventArgs e)
        {
            var rows = gridView_notice.SelectedRows;
            if (rows.Count > 0)
            {
                noticeList[rows[0].Index].Name = tb_noticeName.Text;
                noticeList[rows[0].Index].Code = tb_noticeCode.Text;
                try
                {
                    noticeList[rows[0].Index].Price = Convert.ToDouble(tb_noticePrice.Text);
                    int time = GetSecond(Convert.ToInt32(tb_h.Text),
                        Convert.ToInt32(tb_m.Text), Convert.ToInt32(tb_s.Text));
                    if (time < 1)
                    {
                        MessageBox.Show("주기는 1초 이상만 가능합니다!", "알림",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    noticeList[rows[0].Index].Time = time;
                    noticeList[rows[0].Index].Format = GetTimeFormat(time);
                    noticeList[rows[0].Index].Mode = combo_noticeMode.SelectedIndex == 0 ? Notice.UP : Notice.Down;
                }
                catch (Exception)
                {
                    MessageBox.Show("값을 제대로 입력해주세요!", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                gridView_notice.DataSource = null;
                gridView_notice.DataSource = noticeList;
            }
        }

        private void combo_noticeKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_noticeCoinList.Items.Clear();
            foreach (var item in coinList)
            {
                if (item.Code.IndexOf(combo_noticeKind.SelectedItem.ToString()) >= 0)
                {
                    combo_noticeCoinList.Items.Add($"{item.Name} / {item.Code}");
                }
            }
        }

        private void combo_noticeCoinList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] strs = combo_noticeCoinList.SelectedItem.ToString().Split('/');
            tb_noticeName.Text = strs[0].Trim();
            tb_noticeCode.Text = strs[1].Trim();
        }

        private void gridView_notice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (noticeList.Count > 0)
            {
                int index = gridView_notice.SelectedRows[0].Index;
                tb_noticeName.Text = noticeList[index].Name;
                tb_noticeCode.Text = noticeList[index].Code;
                tb_noticePrice.Text = noticeList[index].Price.ToString();
                tb_h.Text = (noticeList[index].Time / 3600).ToString();
                tb_m.Text = (noticeList[index].Time / 60 % 60).ToString();
                tb_s.Text = (noticeList[index].Time % 60).ToString();
                combo_noticeMode.SelectedItem = noticeList[index].Mode;
            }
        }

        private void gridView_notice_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            GridViewRowPostPaint(e);
        }

        private void GridViewRowPostPaint(DataGridViewRowPostPaintEventArgs e)
        {
            string drawString = (e.RowIndex + 1).ToString();
            int x = e.RowBounds.Location.X + 16;
            int y = e.RowBounds.Location.Y + 3;
            e.Graphics.DrawString(drawString, new Font(Setting.Font, 9, FontStyle.Regular), Brushes.Black, x, y);
        }
    }
}
