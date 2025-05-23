using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Palette
{
    public partial class Form1 : Form
    {
        int x = 0;
        int y = 0;
        int blue = 0;
        public Form1()
        {
            MinimumSize = new Size(918, 619);
            MaximumSize = new Size(918, 619);
            InitializeComponent();
            MouseWheel += MainColorPanel_MouseWheel; //控制滾輪變化藍色
            Instructions.Text = "滑鼠移動：改變顏色　｜　滾輪：調整藍色值　｜　點擊：加入色塊";
        }

        private void MainColorPanel_Click(object sender, EventArgs e)
        {
            Color bgColor = MainColorPanel.BackColor;
            int maxColors = 6;
            int r = bgColor.R;
            int g = bgColor.G;
            int b = bgColor.B;
            
            string rgbText = "RGB(" + r + "," + g + "," + b + ")";
            string hexText = "#" + r.ToString("X2") + g.ToString("X2") + b.ToString("X2");

            // 色塊Panel
            Panel newColorPanel = new Panel();
            newColorPanel.Size = new Size(50, 50);
            newColorPanel.BackColor = bgColor;
            newColorPanel.Location = new Point(25, 0);
            // 顏色label
            Label colorLabel = new Label();
            colorLabel.Text = rgbText + "\n" + hexText;
            colorLabel.AutoSize = false;
            colorLabel.Size = new Size(100, 80); // 保持容器大小
            colorLabel.Font = new Font("Arial", 8);
            colorLabel.Location = new Point(0, 55);
            colorLabel.TextAlign = ContentAlignment.TopCenter;

            // container包色塊、文字
            Panel container = new Panel();
            container.Size = new Size(100, 80);
            container.Margin = new Padding(4);
            container.Controls.Add(newColorPanel);
            container.Controls.Add(colorLabel);
            
            if (flowLayoutPanel1.Controls.Count >= maxColors)
            {
                flowLayoutPanel1.Controls.RemoveAt(0); // 移除最舊的那一個
            }
            flowLayoutPanel1.Controls.Add(container);
        }

        private void MainColorPanel_MouseMove(object sender, MouseEventArgs e)
        {
            x = e.Location.X;
            y = e.Location.Y;
            int red = (int)(255 * (e.X / (float)MainColorPanel.Width));
            int green = (int)(255 * (e.Y / (float)MainColorPanel.Height));

            MainColorPanel.BackColor = Color.FromArgb(red, green, blue);
        }

        private void MainColorPanel_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)    // 往上滾輪，增加藍色值
            {
                blue += 5;
            }
            else
            {
                blue -= 5;      // 往下滾輪，減少藍色值
            }
            if (blue < 0)
            {
                blue = 0;
            }
            else if (blue > 255)
            {
                blue = 255;
            }

        }

    }
}
