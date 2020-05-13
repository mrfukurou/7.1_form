using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			try
			{
				int s = 0;
				StringBuilder a = new StringBuilder(stroka.Text);
				string str = a.ToString();
				if (!String.IsNullOrWhiteSpace(str))
				{
					for (int i = 0; i < str.Length; i++)
					{
						if (str[i] == ':') s++;
					}
					if (s > 0)
						rez.Text = Convert.ToString(str.Substring(str.LastIndexOf(':') + 1));
					else rez.Text = Convert.ToString("Двоеточие в предложении отсутствует!");
					attention.Clear();
				}
				else
				{
					throw new Exception();
				}
			}
			catch { attention.Text = Convert.ToString("Некорректный ввод!"); }

		}

		private void button2_Click(object sender, EventArgs e)
		{
			attention.Clear();
			rez.Clear();
			stroka.Clear();

		}
	}
}
