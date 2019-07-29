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
    public partial class MainFormPointOne : Form
    {

        int topPadding = 10;
        int leftPadding = 10;
        int btnHeight = 25;
        int btnWidth = 60;
        int n = 10;
        int padding = 2;

        private static Random random = new Random();


        public MainFormPointOne()
        {
            InitializeComponent();
            MyButton();

            /*
             * Настройка txtResult
             * Выравнивание относительно размеров кнопок
             */
            txtResult.Visible = true;
            txtResult.ReadOnly = true;
            txtResult.Top = btnHeight + padding + topPadding;
            txtResult.Left = leftPadding + 1;
            txtResult.Width = n * btnWidth - padding;

            this.MinimumSize = this.MaximumSize = new Size(n * (btnWidth + padding) + (2 * leftPadding), btnHeight + padding + 3 * topPadding + txtResult.Height * 2 + topPadding);
        }

        public void MyButton()
        {
            int top = topPadding;
            int left = leftPadding;
            for (int i = 0; i < n; i++)
            {
                Button button = new Button();
                button.Height = btnHeight;
                button.Width = btnWidth;
                button.Left = left;
                button.Top = topPadding;
                button.Text = i.ToString();
                button.Click += ButtonOnClick;
                this.Controls.Add(button);

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
    }
}