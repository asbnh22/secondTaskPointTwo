using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondTaskPartTwo
{
    public partial class MainFormPointTwo : Form
    {
        int topPadding = 10;
        int leftPadding = 10;
        int btnHeight = 25;
        int btnWidth = 60;
        int m = 5;
        int n = 10;
        int padding = 2;

        private static Random random = new Random();
        

        public MainFormPointTwo()
        {
            InitializeComponent();
            MyButton();

            /*
             * Настройка txtResult
             * Выравнивание относительно размеров кнопок
             */
            txtResult.Visible = true;
            txtResult.ReadOnly = true;
            txtResult.Top = m * (btnHeight + padding) + topPadding;
            txtResult.Left = leftPadding + 1;
            txtResult.Width = n * btnWidth - padding;

            this.MinimumSize = this.MaximumSize = new Size(n * (btnWidth + padding) + (2 * leftPadding), m*(btnHeight+padding) + 3 * topPadding + txtResult.Height*2 + topPadding);

        }

        
        public void MyButton()
        {
            int top;
            int left = leftPadding;
            for (int i = 0; i < n; i++)
            {
                top = topPadding;
                for (int j = 0; j < m; j++)
                {
                    Button button = new Button();
                    button.Height = btnHeight;
                    button.Width = btnWidth;
                    button.Left = left;
                    button.Top = top;
                    button.Text = RandomChar().ToString();
                    button.Click += ButtonOnClick;
                    this.Controls.Add(button);

                    top += btnHeight + 2;
                }
                left += btnWidth;
            }
        }

        private void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;
            if (button != null)
            {
                txtResult.Text += button.Text;
            }
        }

        public static char RandomChar()
        {
            const string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            return (char)(chars[random.Next(chars.Length)]);
        }

        /* 
         * Можно так для формирования строки произвольной длины
         */
        /*public static string RandomString(int length)
        {
            const string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }*/

    }
}
