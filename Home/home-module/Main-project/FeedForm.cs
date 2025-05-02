using System;
using System.Windows.Forms;
using FeedModule;
using Main_project.Properties;
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


            //feedService.AgregarPost(new Post { Author = "Jesus Dizb", img = Properties.Resources.img1, Contenido = "good morning, el dia de hoy..", date = DateTime.Now });
            feedService.AgregarPost(new Post { Author = "Derick Rose", img = Image.FromFile("C:\\Users\\Carlo\\source\\repos\\TECplace\\TECplace\\Main-project\\Resources\\img2.jpg"), Contenido = "Venta de todo timpo de sabirtas", date = DateTime.Now.AddMinutes(-30) });
            feedService.AgregarPost(new Post { Author = "David Goggins", img = Image.FromFile("C:\\Users\\Carlo\\source\\repos\\TECplace\\TECplace\\Main-project\\Resources\\img4.jpg"), Contenido = "Venta de saborines de oreo", date = DateTime.Now.AddHours(-1) });
            feedService.AgregarPost(new Post { Author = "User", img = Image.FromFile("C:\\Users\\Carlo\\source\\repos\\TECplace\\TECplace\\Main-project\\Resources\\img5.jpg"), Contenido = "Me queda solo un pay de queso, estoy en el edicio B", date = DateTime.Now.AddHours(-1) });
            feedService.AgregarPost(new Post { Author = "David goggins", img = Image.FromFile("C:\\Users\\Carlo\\source\\repos\\TECplace\\TECplace\\Main-project\\Resources\\img6.jpg"), Contenido = "Me encuentro vendiendo pays de fresa, estoy en las hamacas", date = DateTime.Now.AddHours(-1) });
            feedService.AgregarPost(new Post { Author = "the rock", img = Image.FromFile("C:\\Users\\Carlo\\source\\repos\\TECplace\\TECplace\\Main-project\\Resources\\im4.jpg"), Contenido = "Venta de rico spagueti, disponible 3!!", date = DateTime.Now.AddHours(-1) });
            feedService.AgregarPost(new Post { Author = "Mark z", img = Image.FromFile("C:\\Users\\Carlo\\source\\repos\\TECplace\\TECplace\\Main-project\\Resources\\img3.jpg"), Contenido = "Vendo domplins, ordena el tuyo ahora", date = DateTime.Now.AddHours(-1) });
            //feedService.AgregarPost(new Post { Author = "Lira", img = Image.FromFile(), Contenido = "¿Qué opinan del clima hoy?", date = DateTime.Now.AddHours(-1) });

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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanelOptions_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }
    }
}
