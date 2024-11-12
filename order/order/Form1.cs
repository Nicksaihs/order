namespace order
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static string msg = "";
        public static double price = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            itemform f1 = new itemform();
            f1.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            textBox1.Text = msg;
        }

        private void ­º­¶ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ÂIÀ\ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            itemform f2 = new itemform();
            f2.ShowDialog();
        }
    }
}