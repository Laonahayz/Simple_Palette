namespace Simple_Palette
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MainColorPanel = new System.Windows.Forms.Panel();
            this.Instructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 453);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(876, 107);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // MainColorPanel
            // 
            this.MainColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainColorPanel.Location = new System.Drawing.Point(12, 40);
            this.MainColorPanel.Name = "MainColorPanel";
            this.MainColorPanel.Size = new System.Drawing.Size(876, 390);
            this.MainColorPanel.TabIndex = 1;
            this.MainColorPanel.Click += new System.EventHandler(this.MainColorPanel_Click);
            this.MainColorPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainColorPanel_MouseMove);
            // 
            // Instructions
            // 
            this.Instructions.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Instructions.Location = new System.Drawing.Point(12, 9);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(876, 22);
            this.Instructions.TabIndex = 2;
            this.Instructions.Text = "Instructions Text";
            this.Instructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(900, 572);
            this.Controls.Add(this.Instructions);
            this.Controls.Add(this.MainColorPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "簡易調色盤";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel MainColorPanel;
        private System.Windows.Forms.Label Instructions;
    }
}

