using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Xml.Linq;

namespace ПР3
{
    public partial class Form3 : Form
    {
        /// <summary>
        /// фильм-время
        /// </summary>
        Dictionary<string, double> film = new Dictionary<string, double>()
        {
            ["Сто лет тому вперед"] = 8.20,
            ["Блиндаж"] = 16.05,
            ["Неприличные гости"] = 18.30,
            ["Батя"] = 14.00,
            ["Астрал.Шёпот мертвых"] = 22.45
        };
        /// <summary>
        /// время-зал
        /// </summary>
        Dictionary<double, uint> time = new Dictionary<double, uint>()
        {
            [8.20] = 1,
            [16.05] = 2,
            [18.30] = 3,
            [14.00] = 1,
            [22.45] = 3,
        };
        /// <summary>
        /// место-ряд
        /// </summary>
        Dictionary<int, uint> place = new Dictionary<int, uint>()
        {
            [11] = 1,            [21] = 1,            [31] = 1,             [41] = 1,            [51] = 1,            [61] = 1,
            [12] = 2,            [22] = 2,            [32] = 2,             [42] = 2,            [52] = 2,            [62] = 2,
            [13] = 3,            [23] = 3,            [33] = 3,             [43] = 3,            [53] = 3,            [63] = 3,
            [14] = 4,            [24] = 4,            [34] = 4,             [44] = 4,            [54] = 4,            [64] = 4,
            [15] = 5,            [25] = 5,            [35] = 5,             [45] = 5,            [55] = 5,            [65] = 5,
            [16] = 6,            [26] = 6,            [36] = 6,             [46] = 6,            [56] = 6,            [66] = 6
        };
        string name;
        uint hall;
        double times;
        public int numSite = 0, numRow = 0;
        List<int> list;
        public Form3(string name, List<int> list)
        {
            this.list=list;
            this.name = name;
            InitializeComponent();
            film.TryGetValue(name, out double times);
            this.times = times;
            time.TryGetValue(times, out uint hall);
            this.hall = hall;
            foreach (int variable in list)
            {
                switch (variable)
                {
                    case 11: pictureBoxG11.Visible = false; break;
                    case 12: pictureBoxG12.Visible = false; break;
                    case 13: pictureBoxG13.Visible = false; break;
                    case 14: pictureBoxG14.Visible = false; break;
                    case 15: pictureBoxG15.Visible = false; break;
                    case 16: pictureBoxG16.Visible = false; break;
                    case 21: pictureBoxG21.Visible = false; break;
                    case 22: pictureBoxG22.Visible = false; break;
                    case 23: pictureBoxG23.Visible = false; break;
                    case 24: pictureBoxG24.Visible = false; break;
                    case 25: pictureBoxG25.Visible = false; break;
                    case 26: pictureBoxG26.Visible = false; break;
                    case 31: pictureBoxG31.Visible = false; break;
                    case 32: pictureBoxG32.Visible = false; break;
                    case 33: pictureBoxG33.Visible = false; break;
                    case 34: pictureBoxG34.Visible = false; break;
                    case 35: pictureBoxG35.Visible = false; break;
                    case 36: pictureBoxG36.Visible = false; break;
                    case 41: pictureBoxG41.Visible = false; break;
                    case 42: pictureBoxG42.Visible = false; break;
                    case 43: pictureBoxG43.Visible = false; break;
                    case 44: pictureBoxG44.Visible = false; break;
                    case 45: pictureBoxG45.Visible = false; break;
                    case 46: pictureBoxG46.Visible = false; break;
                    case 51: pictureBoxG51.Visible = false; break;
                    case 52: pictureBoxG52.Visible = false; break;
                    case 53: pictureBoxG53.Visible = false; break;
                    case 54: pictureBoxG54.Visible = false; break;
                    case 55: pictureBoxG55.Visible = false; break;
                    case 56: pictureBoxG56.Visible = false; break;
                    case 61: pictureBoxG61.Visible = false; break;
                    case 62: pictureBoxG62.Visible = false; break;
                    case 63: pictureBoxG63.Visible = false; break;
                    case 64: pictureBoxG64.Visible = false; break;
                    case 65: pictureBoxG65.Visible = false; break;
                    case 66: pictureBoxG66.Visible = false; break;
                }
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NumRow_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void NumSite_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                errorProvider2.Clear();
                errorProvider1.Clear();
                bool ok = true;
                string s_numSite = NumSite.Text;
                if (s_numSite.Length > 0)
                    numSite = int.Parse(NumSite.Text);
                string s_sumRow = NumRow.Text;
                if (s_sumRow.Length > 0)
                    numRow = int.Parse(NumRow.Text);
                if (string.IsNullOrEmpty(NumRow.Text))
                {
                    errorProvider1.SetError(NumRow, "Ошибка");
                    ok = false;
                }
                if (string.IsNullOrEmpty(NumSite.Text))
                {
                    errorProvider2.SetError(NumSite, "Ошибка");
                    ok = false;
                }
                if (Convert.ToInt32(NumRow.Text) > 6 && Convert.ToInt32(NumRow.Text) < 0)
                {
                    errorProvider1.SetError(NumRow, "нет такого ряда");
                    ok = false;
                }
                if (Convert.ToInt32(NumSite.Text) > 6 && Convert.ToInt32(NumSite.Text) < 0)
                {
                    errorProvider2.SetError(NumSite, "нет такого места");
                    ok = false;
                }
                if (list.Contains(Convert.ToInt32(Convert.ToString(numSite) + Convert.ToString(numRow))))
                {
                    errorProvider2.SetError(NumSite, "это место занято");
                    ok = false;
                }
                if (ok)
                {
                    Close();
                    MessageBox.Show($"Вы купили билет на фильм '{name}' в {times}. Это кино пройдет в {hall} зале, ваше место №{numSite} ряд №{numRow}");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Ошибка:" + ee);
            }
        }
    }
}
