using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ПР3
{
    public partial class Form1 : Form
    {
        List<int>[] list = new List<int>[]
        {
            new List<int> { 0, 1 },
            new List<int> { 0, 1 },
            new List<int> { 0, 1 },
            new List<int> { 0, 1 },
            new List<int> { 0, 1 }
        };
         static Dictionary<uint, uint> place = new Dictionary<uint, uint>()
        {
            [11] = 1,            [21] = 1,            [31] = 1,             [41] = 1,            [51] = 1,            [61] = 1,
            [12] = 2,            [22] = 2,            [32] = 2,             [42] = 2,            [52] = 2,            [62] = 2,
            [13] = 3,            [23] = 3,            [33] = 3,             [43] = 3,            [53] = 3,            [63] = 3,
            [14] = 4,            [24] = 4,            [34] = 4,             [44] = 4,            [54] = 4,            [64] = 4,
            [15] = 5,            [25] = 5,            [35] = 5,             [45] = 5,            [55] = 5,            [65] = 5,
            [16] = 6,            [26] = 6,            [36] = 6,             [46] = 6,            [56] = 6,            [66] = 6
        };
        Dictionary<uint, uint> place0 = place;
        Dictionary<uint, uint> place1 = place;
        Dictionary<uint, uint> place2 = place;
        Dictionary<uint, uint> place3 = place;
        Dictionary<uint, uint> place4 = place;

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// открытие формы 2
        /// </summary>
        private void InfProgramm_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
        /// <summary>
        /// настройки формы 2
        /// </summary>
        private void buttonFilm1_Click(object sender, EventArgs e)
        {
            Open("Астрал.Шёпот мертвых", place0);
        }
        /// <summary>
        /// настройки формы 2
        /// </summary>
        private void buttonFilm2_Click(object sender, EventArgs e)
        {
            Open("Блиндаж", place1);
        }
        /// <summary>
        /// настройки формы 2
        /// </summary>
        private void buttonFilm3_Click(object sender, EventArgs e)
        {
            Open("Батя", place2);
        }
        /// <summary>
        /// настройки формы 2
        /// </summary>
        private void buttonFilm4_Click(object sender, EventArgs e)
        {
            Open("Неприличные гости", place3);
        }
        /// <summary>
        /// настройки формы 2
        /// </summary>
        private void buttonFilm5_Click(object sender, EventArgs e)
        {
            Open("Сто лет тому вперед", place4);
        }
        /// <summary>
        /// открытие формы 3, запись выбранного места в список недоступных
        /// </summary>
        public void Open(string name, Dictionary<uint, uint> index)
        {
            Form3 form3 = new Form3(name, index);
            form3.ShowDialog();
            index.Remove(Convert.ToUInt32(Convert.ToString(form3.numRow) + Convert.ToString(form3.numSite)));
        }
    }
}
