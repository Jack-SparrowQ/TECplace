using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PostModule;
namespace Main_project
{
    
    public partial class PostItem : UserControl
    {
        private Label lblAutor;
        private Label lblContenido;
        private PictureBox pbImagen;
        private Label lblFecha;
        public PostItem(Post post)
        {
            InitializeComponent();
            SetUpUI(post);

        }

        private void SetUpUI(Post post)
        {
            this.Width = 550;
            this.Padding = new Padding(10);
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.White;
            this.Margin = new Padding(0,0,0,20);

            lblAutor = new Label
            {
                Text = post.Author,
                Font = new Font("Arial", 10, FontStyle.Bold),
                AutoSize = true
            };

            lblContenido = new Label
            {
                Text = post.Contenido,
                Font = new Font("Arial", 9),
                AutoSize = true,
                MaximumSize = new Size(430, 0)
            };

            lblFecha = new Label
            {
                Text = post.date.ToString("dd/MM/yyyy hh:mm tt"),
                Font = new Font("Segoe UI", 8),
                ForeColor = Color.Gray,
                AutoSize = true
            };

            pbImagen = new PictureBox
            {
                Image = post.img,
                SizeMode = PictureBoxSizeMode.Zoom,
                Width = 400,
                Height = 250,
                Margin = new Padding(0, 10, 0, 10)
            };

            FlowLayoutPanel headerLayout = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.LeftToRight,
                AutoSize = true,
            };

            headerLayout.Controls.Add(lblAutor);
            headerLayout.Controls.Add(lblFecha);

            FlowLayoutPanel layout = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                AutoSize = true,
                WrapContents = false,
            };
            layout.Controls.Add(headerLayout);
            layout.Controls.Add(pbImagen);
            layout.Controls.Add(lblContenido);
            

            this.Controls.Add(layout);
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
