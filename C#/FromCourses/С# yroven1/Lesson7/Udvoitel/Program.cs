using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udvoitel
{
    class Program
    {
        static void Main()
        {
            Form2 form2 = new Form2();
            Application.Run(form2);
            Form1 form = new Form1();
            Application.Run(form);
        }

        class Form2 : Form
        {
            Form1 form = new Form1();

            
            Label startGame;
            Button game;

            public Form2()
            {
                startGame = new Label();
                startGame.Top = 10;
                startGame.Left = 10;
                startGame.Text = "Форма запуска игры";

                game = new Button();
                game.Top = 200;
                game.Left = 100;
                game.Text = "Start Game";

                startGame.Parent = this;
                game.Parent = this;

                game.Click += Game_Click;
            }

            private void Game_Click(object sender, EventArgs e)
            {
                form.Show();
                
            }
        }

        class Form1 : Form
        {
            Label labelCurrent;
            Label labelCount;
            Button btnPlus;
            Button btnMultu;
            Button btnReset;

            Udvoitel udv = new Udvoitel(100);
        

            public Form1()
            {
                labelCurrent = new Label();
                labelCurrent.Top = 10;
                labelCurrent.Left = 10;
                labelCurrent.Text = "1";
                labelCount = new Label();
                labelCount.Top = 70;
                labelCount.Left = 10;
                labelCount.Text = "0";
                btnPlus = new Button();
                btnPlus.Top = 200;
                btnPlus.Left = 10;
                btnPlus.Text = "+1";
                btnMultu = new Button();
                btnMultu.Top = 200;
                btnMultu.Left = 100;
                btnMultu.Text = "x2";
                btnReset = new Button();
                btnReset.Top = 200;
                btnReset.Left = 190;
                btnReset.Text = "Reset";
                btnMultu.Parent = this;
                btnPlus.Parent = this;
                btnReset.Parent = this;
                labelCurrent.Parent = this;
                labelCount.Parent = this;

                btnMultu.Click += BtnMultu_Click;
                btnPlus.Click += BtnPlus_Click;
                btnReset.Click += BtnReset_Click;
            }


            void Draw()
            {
                labelCurrent.Text = udv.Current.ToString();
                labelCount.Text = udv.Count.ToString();
            }

            private void BtnReset_Click(object sender, EventArgs e)
            {
                udv.Reset();
                
                Draw();
                labelCount.Text = "0";

            }

            private void BtnPlus_Click(object sender, EventArgs e)
            {
                udv.Plus();
                udv.CountP();
                Draw();
            }

            private void BtnMultu_Click(object sender, EventArgs e)
            {
                udv.Multi();
                udv.CountP();
                Draw();
            }
        }
    }
}
