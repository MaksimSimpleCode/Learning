using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeliveOrNotBelive
{
    public partial class Form1 : Form
    {
        TrueFalse tf = new TrueFalse();
        public Form1()
        {
            InitializeComponent();
            label1.DataBindings.Add("Text", this, "Width");
            label1.DataBindings[0].DataSourceUpdateMode.On
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tf.List.Add(new Question(tbQestion.Text, cbTruth.Checked));
            tbQestion.Text = "";
            cbTruth.Checked = false;
            this.Text = "Всего вопросов: " + tf.List.Count;
            numericUpDown1.Maximum = tf.List.Count - 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tf.List.RemoveAt((int)numericUpDown1.Value);
            numericUpDown1.Maximum = tf.List.Count - 1;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            tbQestion.Text = tf.List[(int)numericUpDown1.Value].Text;
            cbTruth.Checked = tf.List[(int)numericUpDown1.Value].Truth;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           tf.List[(int)numericUpDown1.Value].Text = tbQestion.Text;
            tf.List[(int)numericUpDown1.Value].Truth = cbTruth.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tf.List.Add(new Question());
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
           if( dlg.ShowDialog() == DialogResult.OK)
           {
                 tf.Save(dlg.FileName);
           }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Все файлы(*.*)|*.*|*.xml|*.xml";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tf.Load(dlg.FileName);
                tbQestion.Text = tf.List[0].Text;
                cbTruth.Checked = tf.List[0].Truth;
                numericUpDown1.Maximum = tf.List.Count -1;
            }
        }

        private void tsmiNew_Click(object sender, EventArgs e)
        {
            tbQestion.Text = "";
            cbTruth.Checked = false;
            tf.List.Clear();
            this.Text = "Всего вопросов: " + tf.List.Count;
        }
    }
}
