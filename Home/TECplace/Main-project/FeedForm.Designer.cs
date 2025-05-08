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
            profileBtn = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            settingsBtn = new Button();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(profileBtn);
            flowLayoutPanel1.Controls.Add(pictureBox2);
            flowLayoutPanel1.Controls.Add(settingsBtn);
            flowLayoutPanel1.Location = new Point(738, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(213, 123);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 59);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            // FeedForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(963, 547);
            Controls.Add(flowLayoutPanel1);
            Name = "FeedForm";
            Text = "Form1";
            Load += FeedForm_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button profileBtn;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button settingsBtn;
    }
}
