using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace order
{
    public partial class DiscountForm : Form
    {
        public DiscountForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm.msg += "===================\r\n";
            if (checkBox1.Checked)
            {
                MainForm.price = MainForm.price * 0.95;
                MainForm.msg += "會員打九五折\r\n";
            }
            if (checkBox2.Checked)
            {
                MainForm.price = MainForm.price - 20;
                MainForm.msg += "折扣20元\r\n";
            }

            MainForm.msg += "實收" + Math.Round(MainForm.price, 0).ToString()+Environment.NewLine;
            this.Dispose();
        }
    }
}
