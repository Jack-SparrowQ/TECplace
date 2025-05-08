using System;
using System.Windows.Forms;
using FeedModule;
using PostModule;

namespace Main_project
{
    public partial class FeedForm : Form
    {
        private FeedService feedService = new FeedService();

        public FeedForm()
        {
            InitializeComponent();
            CargarFeed();
        }


        private void FeedForm_Resize(object sender, EventArgs e)
        {
            CentrarFlowLayoutPanel();
        }


        private void CargarFeed()
        {
            flowLayoutPanel.Controls.Clear();


            feedService.AgregarPost(new Post { Author = "Juan", Contenido = "Mi primer post", date = DateTime.Now });
            feedService.AgregarPost(new Post { Author = "Maria", Contenido = "Hola a todos!", date = DateTime.Now.AddMinutes(-30) });
            feedService.AgregarPost(new Post { Author = "Carlos", Contenido = "�Qu� opinan del clima hoy?", date = DateTime.Now.AddHours(-1) });
            feedService.AgregarPost(new Post { Author = "Carlos", Contenido = "�Qu� opinan del clima hoy?", date = DateTime.Now.AddHours(-1) });
            feedService.AgregarPost(new Post { Author = "David goggins", Contenido = "�Qu� opinan del clima hoy?", date = DateTime.Now.AddHours(-1) });
            feedService.AgregarPost(new Post { Author = "the rock", Contenido = "�Qu� opinan del clima hoy?", date = DateTime.Now.AddHours(-1) });
            feedService.AgregarPost(new Post { Author = "Mark z", Contenido = "�Qu� opinan del clima hoy?", date = DateTime.Now.AddHours(-1) });
            feedService.AgregarPost(new Post { Author = "Lira", Contenido = "�Qu� opinan del clima hoy?", date = DateTime.Now.AddHours(-1) });

            var posts = feedService.ObtenerPosts();

            foreach (var post in posts)
            {
                var postItem = new PostBox(post);
                flowLayoutPanel.Controls.Add(postItem);
            }
        }

        private void FeedForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
