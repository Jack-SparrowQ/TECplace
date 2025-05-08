using System;
using System.Windows.Forms;
using FeedModule;
using PostModule;

namespace Main_project
{
    public partial class FeedForm : Form
    {
        private FeedService feedService = new FeedService();
        private Panel panelContenedor;
        private FlowLayoutPanel flowLayoutPanelFeed;
        public FeedForm()
        {
            InitializeComponent();
            ConfigurarUI();
            CargarFeed();
        }

        private void ConfigurarUI()
        {
            this.Text = "Feed";
            this.Size = new System.Drawing.Size(1200, 800);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Panel contenedor centrado
            panelContenedor = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };

            // FlowLayoutPanel para los posts
            flowLayoutPanelFeed = new FlowLayoutPanel
            {
                AutoSize = true,

                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                Padding = new Padding(20),
                Width = 500 // Fijar un ancho para centrar los posts
            };

            // Agregar FlowLayoutPanel dentro de un Panel
            panelContenedor.Controls.Add(flowLayoutPanelFeed);
            this.Controls.Add(panelContenedor);

            this.Resize += FeedForm_Resize;
            CentrarFlowLayoutPanel();

        }


        private void FeedForm_Resize(object sender, EventArgs e)
        {
            CentrarFlowLayoutPanel();
        }

        private void CentrarFlowLayoutPanel()
        {
            int x = (panelContenedor.Width - flowLayoutPanelFeed.Width) / 2;
            if (x < 0) x = 0; // Evitar posiciones negativas
            flowLayoutPanelFeed.Location = new System.Drawing.Point(x, 20);
        }
        private void CargarFeed()
        {
            flowLayoutPanelFeed.Controls.Clear();


            feedService.AgregarPost(new Post { Author = "Juan", Contenido = "Mi primer post", date = DateTime.Now });
            feedService.AgregarPost(new Post { Author = "Maria", Contenido = "Hola a todos!", date = DateTime.Now.AddMinutes(-30) });
            feedService.AgregarPost(new Post { Author = "Carlos", Contenido = "¿Qué opinan del clima hoy?", date = DateTime.Now.AddHours(-1) });
            feedService.AgregarPost(new Post { Author = "Carlos", Contenido = "¿Qué opinan del clima hoy?", date = DateTime.Now.AddHours(-1) });
            feedService.AgregarPost(new Post { Author = "David goggins", Contenido = "¿Qué opinan del clima hoy?", date = DateTime.Now.AddHours(-1) });
            feedService.AgregarPost(new Post { Author = "the rock", Contenido = "¿Qué opinan del clima hoy?", date = DateTime.Now.AddHours(-1) });
            feedService.AgregarPost(new Post { Author = "Mark z", Contenido = "¿Qué opinan del clima hoy?", date = DateTime.Now.AddHours(-1) });
            feedService.AgregarPost(new Post { Author = "Lira", Contenido = "¿Qué opinan del clima hoy?", date = DateTime.Now.AddHours(-1) });

            var posts = feedService.ObtenerPosts();

            foreach (var post in posts)
            {
                var postItem = new PostBox(post);
                flowLayoutPanelFeed.Controls.Add(postItem);
            }
        }

        private void FeedForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
