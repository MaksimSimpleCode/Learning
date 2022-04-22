using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Форма загрузилась");
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            Console.WriteLine("Форму передвинули");
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Клик", "Внимание", MessageBoxButtons.OKCancel) == DialogResult.OK) MessageBox.Show("ОК");
        }
    }
}
