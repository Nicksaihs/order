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
    public partial class itemform : Form
    {
        public itemform()
        {
            InitializeComponent();
        }

        
        string[] mainDish = new string[] { "鱈魚堡", "牛肉堡", "麥脆雞", "雜菜堡" };
        int[] dishPrice = new int[] { 50, 70, 100, 30 };
        string[] mainDessert = new string[] { "冰炫風", "蘋果派", "勁辣雞翅" };
        int[] dessertPrice = new int[] { 50, 70, 100 };
        private void itemform_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(mainDish);
            comboBox1.SelectedIndex = 0;
            comboBox2.Items.AddRange(mainDessert);
            comboBox2.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm.msg += comboBox1.Text + " "+ dishPrice[comboBox1.SelectedIndex]+ Environment.NewLine;
            MainForm.msg += comboBox2.Text + " " + dessertPrice[comboBox2.SelectedIndex] + Environment.NewLine;
            // 價錢合計
            // price = 主餐價錢[ 餐點x ] + 點心價錢 [ 點心y ]
            MainForm.price = dishPrice[comboBox1.SelectedIndex]+dessertPrice[comboBox2.SelectedIndex];
            MainForm.msg += $"合計 {MainForm.price} 元\r\n";
            this.Dispose();

            DiscountForm d1 = new DiscountForm();
            d1.ShowDialog();



        }
    }
}
