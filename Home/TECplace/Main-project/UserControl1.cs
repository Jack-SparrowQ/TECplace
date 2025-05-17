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
    public partial class PostBox : UserControl
    {
        public PostBox(Post post)
        {
            InitializeComponent();
            nameUser.Text = post.Author;
            date.Text = post.date.ToString("dd/MM/yyyy hh:mm tt");
            description.Text = post.Contenido;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
