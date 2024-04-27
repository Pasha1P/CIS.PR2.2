using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПР3
{
    public partial class Form1 : Form
    {
        List<int> list = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void InfProgramm_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Open("Астрал.Шёпот мертвых");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Open("Блиндаж");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Open("Батя");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Open("Неприличные гости");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Open("Сто лет тому вперед");
        }
        public void Open(string name)
        {
            Form3 form3 = new Form3(name, list);
            form3.ShowDialog();
            list.Add(Convert.ToInt32(Convert.ToString(form3.numSite)+ Convert.ToString(form3.numRow)));
        }
    }
}
