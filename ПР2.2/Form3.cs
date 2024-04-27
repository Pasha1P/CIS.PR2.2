using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ПР3
{
    public partial class Form3 : Form
    {
        /// <summary>
        /// Dictionary фильм-время
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
        /// Dictionary время-зал
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
        /// Dictionary место-ряд
        /// </summary>
        string name;
        uint hall;
        double times;
        public int numSite = 0, numRow = 0;
        Dictionary<uint, uint> list;
        /// <summary>
        /// принятие переменных и скрытие уже выбранных элементов
        /// </summary>
        public Form3(string name, Dictionary<uint, uint> list)
        {
            this.list=list;
            this.name = name;
            InitializeComponent();
            film.TryGetValue(name, out double times);
            this.times = times;
            time.TryGetValue(times, out uint hall);
            this.hall = hall;
            foreach (KeyValuePair<uint, uint> KeyValue in list)
            {
                switch (KeyValue.Key)
                {
                    case 11: pictureBoxG11.Visible = true; break;
                    case 12: pictureBoxG12.Visible = true; break;
                    case 13: pictureBoxG13.Visible = true; break;
                    case 14: pictureBoxG14.Visible = true; break;
                    case 15: pictureBoxG15.Visible = true; break;
                    case 16: pictureBoxG16.Visible = true; break;
                    case 21: pictureBoxG21.Visible = true; break;
                    case 22: pictureBoxG22.Visible = true; break;
                    case 23: pictureBoxG23.Visible = true; break;
                    case 24: pictureBoxG24.Visible = true; break;
                    case 25: pictureBoxG25.Visible = true; break;
                    case 26: pictureBoxG26.Visible = true; break;
                    case 31: pictureBoxG31.Visible = true; break;
                    case 32: pictureBoxG32.Visible = true; break;
                    case 33: pictureBoxG33.Visible = true; break;
                    case 34: pictureBoxG34.Visible = true; break;
                    case 35: pictureBoxG35.Visible = true; break;
                    case 36: pictureBoxG36.Visible = true; break;
                    case 41: pictureBoxG41.Visible = true; break;
                    case 42: pictureBoxG42.Visible = true; break;
                    case 43: pictureBoxG43.Visible = true; break;
                    case 44: pictureBoxG44.Visible = true; break;
                    case 45: pictureBoxG45.Visible = true; break;
                    case 46: pictureBoxG46.Visible = true; break;
                    case 51: pictureBoxG51.Visible = true; break;
                    case 52: pictureBoxG52.Visible = true; break;
                    case 53: pictureBoxG53.Visible = true; break;
                    case 54: pictureBoxG54.Visible = true; break;
                    case 55: pictureBoxG55.Visible = true; break;
                    case 56: pictureBoxG56.Visible = true; break;
                    case 61: pictureBoxG61.Visible = true; break;
                    case 62: pictureBoxG62.Visible = true; break;
                    case 63: pictureBoxG63.Visible = true; break;
                    case 64: pictureBoxG64.Visible = true; break;
                    case 65: pictureBoxG65.Visible = true; break;
                    case 66: pictureBoxG66.Visible = true; break;
                }
            } // скрытие уже выбранных элементов
        }
        /// <summary>
        /// закрытие формы 3 "раскладка зала"
        /// </summary>
        private void buttonDown_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// запрет ввода нечисел как номер ряда
        /// </summary>
        private void NumRow_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// запрет ввода нечисел как номер места
        /// </summary>
        private void NumSite_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// обравотка вводимых значений, ошибки, вывод информации о купленном билете
        /// </summary>
        private void buttonOk_Click(object sender, EventArgs e)
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
                if (Convert.ToInt32(NumRow.Text) > 6 || Convert.ToInt32(NumRow.Text) < 0)
                {
                    errorProvider1.SetError(NumRow, "нет такого ряда");
                    ok = false;
                }
                if (Convert.ToInt32(NumSite.Text) > 6 || Convert.ToInt32(NumSite.Text) < 0)
                {
                    errorProvider2.SetError(NumSite, "нет такого места");
                    ok = false;
                }
                uint value;
                if (!list.TryGetValue(Convert.ToUInt32(Convert.ToString(numSite) + Convert.ToString(numRow)), out value))
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
