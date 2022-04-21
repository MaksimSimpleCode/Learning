using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class TwoForms
    {
        public static void Main()
        {
            Form form1 =new Form();
            Form form2 = new Form();
            form1.Text = "Эта форма запущена с использованием Run класса Application";
            form2.Text = "Эта форма просто для демонстрации возможности создавать несколько форм";
            form2.Show();
            Application.Run(form1);
            MessageBox.Show("Application.Run()вернул" + "управление в метод Main. До свидания", "Приложение\"Две формы\"");
        }
    }
}
