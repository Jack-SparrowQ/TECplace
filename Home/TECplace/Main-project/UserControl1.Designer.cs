namespace Main_project
{
    partial class PostBox
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostBox));
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanelDown = new TableLayoutPanel();
            description = new Label();
            Price = new Label();
            tableLayoutPanelTop = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            nameUser = new Label();
            date = new Label();
            pictureProfile = new PictureBox();
            ImgPost = new PictureBox();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanelDown.SuspendLayout();
            tableLayoutPanelTop.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImgPost).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(tableLayoutPanelDown);
            flowLayoutPanel1.Controls.Add(tableLayoutPanelTop);
            flowLayoutPanel1.Controls.Add(ImgPost);
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(569, 610);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // tableLayoutPanelDown
            // 
            tableLayoutPanelDown.ColumnCount = 2;
            tableLayoutPanelDown.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.1818161F));
            tableLayoutPanelDown.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.818182F));
            tableLayoutPanelDown.Controls.Add(description, 0, 0);
            tableLayoutPanelDown.Controls.Add(Price, 1, 0);
            tableLayoutPanelDown.Location = new Point(3, 3);
            tableLayoutPanelDown.Name = "tableLayoutPanelDown";
            tableLayoutPanelDown.RowCount = 1;
            tableLayoutPanelDown.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelDown.Size = new Size(550, 74);
            tableLayoutPanelDown.TabIndex = 2;
            // 
            // description
            // 
            description.AutoSize = true;
            description.Location = new Point(3, 0);
            description.Name = "description";
            description.Size = new Size(85, 20);
            description.TabIndex = 0;
            description.Text = "Description";
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.ForeColor = SystemColors.ActiveCaptionText;
            Price.Location = new Point(444, 0);
            Price.Name = "Price";
            Price.Size = new Size(44, 20);
            Price.TabIndex = 1;
            Price.Text = "$$.$$";
            // 
            // tableLayoutPanelTop
            // 
            tableLayoutPanelTop.ColumnCount = 2;
            tableLayoutPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.4876328F));
            tableLayoutPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.51237F));
            tableLayoutPanelTop.Controls.Add(flowLayoutPanel2, 1, 0);
            tableLayoutPanelTop.Controls.Add(pictureProfile, 0, 0);
            tableLayoutPanelTop.Location = new Point(3, 83);
            tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            tableLayoutPanelTop.RowCount = 1;
            tableLayoutPanelTop.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelTop.Size = new Size(566, 72);
            tableLayoutPanelTop.TabIndex = 0;
            tableLayoutPanelTop.Paint += tableLayoutPanel1_Paint;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(nameUser);
            flowLayoutPanel2.Controls.Add(date);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(85, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(213, 66);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // nameUser
            // 
            nameUser.AutoSize = true;
            nameUser.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameUser.Location = new Point(3, 0);
            nameUser.Name = "nameUser";
            nameUser.Size = new Size(110, 38);
            nameUser.TabIndex = 0;
            nameUser.Text = "Naame";
            // 
            // date
            // 
            date.AutoSize = true;
            date.Location = new Point(3, 38);
            date.Name = "date";
            date.Size = new Size(50, 20);
            date.TabIndex = 1;
            date.Text = "label2";
            // 
            // pictureProfile
            // 
            pictureProfile.Image = (Image)resources.GetObject("pictureProfile.Image");
            pictureProfile.Location = new Point(3, 3);
            pictureProfile.Name = "pictureProfile";
            pictureProfile.Size = new Size(70, 66);
            pictureProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureProfile.TabIndex = 0;
            pictureProfile.TabStop = false;
            // 
            // ImgPost
            // 
            ImgPost.Image = (Image)resources.GetObject("ImgPost.Image");
            ImgPost.Location = new Point(3, 161);
            ImgPost.Name = "ImgPost";
            ImgPost.Size = new Size(550, 434);
            ImgPost.SizeMode = PictureBoxSizeMode.CenterImage;
            ImgPost.TabIndex = 1;
            ImgPost.TabStop = false;
            // 
            // PostBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Name = "PostBox";
            Size = new Size(579, 606);
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanelDown.ResumeLayout(false);
            tableLayoutPanelDown.PerformLayout();
            tableLayoutPanelTop.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImgPost).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanelTop;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label nameUser;
        private Label date;
        private PictureBox pictureProfile;
        private PictureBox ImgPost;
        private TableLayoutPanel tableLayoutPanelDown;
        private Label description;
        private Label Price;
    }
}
