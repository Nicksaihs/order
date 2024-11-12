namespace order
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            btnClear = new Button();
            button4 = new Button();
            menuStrip1 = new MenuStrip();
            首頁ToolStripMenuItem = new ToolStripMenuItem();
            點餐ToolStripMenuItem = new ToolStripMenuItem();
            折扣優惠ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.burger;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(487, 35);
            button1.Name = "button1";
            button1.Size = new Size(250, 157);
            button1.TabIndex = 0;
            button1.Text = "外帶";
            button1.TextAlign = ContentAlignment.BottomRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.fast_food;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(487, 239);
            button2.Name = "button2";
            button2.Size = new Size(250, 157);
            button2.TabIndex = 1;
            button2.Text = "內用";
            button2.TextAlign = ContentAlignment.BottomRight;
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(454, 377);
            textBox1.TabIndex = 2;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(163, 408);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(109, 23);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // button4
            // 
            button4.Location = new Point(427, 408);
            button4.Name = "button4";
            button4.Size = new Size(97, 23);
            button4.TabIndex = 4;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 首頁ToolStripMenuItem, 點餐ToolStripMenuItem, 折扣優惠ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // 首頁ToolStripMenuItem
            // 
            首頁ToolStripMenuItem.Name = "首頁ToolStripMenuItem";
            首頁ToolStripMenuItem.Size = new Size(43, 20);
            首頁ToolStripMenuItem.Text = "首頁";
            首頁ToolStripMenuItem.Click += 首頁ToolStripMenuItem_Click;
            // 
            // 點餐ToolStripMenuItem
            // 
            點餐ToolStripMenuItem.Name = "點餐ToolStripMenuItem";
            點餐ToolStripMenuItem.Size = new Size(43, 20);
            點餐ToolStripMenuItem.Text = "點餐";
            點餐ToolStripMenuItem.Click += 點餐ToolStripMenuItem_Click;
            // 
            // 折扣優惠ToolStripMenuItem
            // 
            折扣優惠ToolStripMenuItem.Name = "折扣優惠ToolStripMenuItem";
            折扣優惠ToolStripMenuItem.Size = new Size(67, 20);
            折扣優惠ToolStripMenuItem.Text = "折扣優惠";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(btnClear);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "首頁";
            Activated += MainForm_Activated;
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Button btnClear;
        private Button button4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 首頁ToolStripMenuItem;
        private ToolStripMenuItem 點餐ToolStripMenuItem;
        private ToolStripMenuItem 折扣優惠ToolStripMenuItem;
    }
}