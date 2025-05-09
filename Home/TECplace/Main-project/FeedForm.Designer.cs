namespace Main_project
{
    partial class FeedForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            profileBtn = new Button();
            pictureBox2 = new PictureBox();
            settingsBtn = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel = new FlowLayoutPanel();
            panelContedor = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelContedor.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(profileBtn);
            flowLayoutPanel1.Controls.Add(pictureBox2);
            flowLayoutPanel1.Controls.Add(settingsBtn);
            flowLayoutPanel1.Location = new Point(1040, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(207, 112);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imgprofile;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // profileBtn
            // 
            profileBtn.Location = new Point(68, 3);
            profileBtn.Name = "profileBtn";
            profileBtn.Size = new Size(134, 59);
            profileBtn.TabIndex = 0;
            profileBtn.Text = "Profile";
            profileBtn.UseVisualStyleBackColor = true;
            profileBtn.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.settings_icon;
            pictureBox2.Location = new Point(3, 68);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // settingsBtn
            // 
            settingsBtn.Location = new Point(44, 68);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(94, 29);
            settingsBtn.TabIndex = 2;
            settingsBtn.Text = "Settings";
            settingsBtn.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Location = new Point(285, 67);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(0, 0);
            flowLayoutPanel2.TabIndex = 1;
            flowLayoutPanel2.Paint += flowLayoutPanel2_Paint;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel.Location = new Point(243, 163);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Padding = new Padding(20);
            flowLayoutPanel.Size = new Size(791, 614);
            flowLayoutPanel.TabIndex = 0;
            flowLayoutPanel.WrapContents = false;
            flowLayoutPanel.Paint += flowLayoutPanel_Paint;
            // 
            // panelContedor
            // 
            panelContedor.AutoScroll = true;
            panelContedor.AutoSize = true;
            panelContedor.Controls.Add(tableLayoutPanel1);
            panelContedor.Dock = DockStyle.Fill;
            panelContedor.Location = new Point(0, 0);
            panelContedor.Name = "panelContedor";
            panelContedor.Size = new Size(1251, 780);
            panelContedor.TabIndex = 2;
            panelContedor.Paint += panelContedor_Paint;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.1231232F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.87688F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 213F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 2, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.51724F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 79.48276F));
            tableLayoutPanel1.Size = new Size(1251, 780);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // FeedForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 780);
            Controls.Add(panelContedor);
            Controls.Add(flowLayoutPanel2);
            Name = "FeedForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += FeedForm_Load;
            Resize += FeedForm_Resize;
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelContedor.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        private void CentrarFlowLayoutPanel()
        {
            int x = (panelContedor.Width - flowLayoutPanel.Width) / 2;
            if (x < 0) x = 0; // Evitar posiciones negativas
            flowLayoutPanel.Location = new System.Drawing.Point(x, 20);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private Button profileBtn;
        private PictureBox pictureBox2;
        private Button settingsBtn;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel;
        private Panel panelContedor;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
