using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progeto_anime_fantasi
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblRegistro_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void lblREGISTRAR_Click(object sender, EventArgs e)
        {
            Usuario novosAnimes = new Usuario()
            {
                Nome = tbxNome.Text,
                NomeAnime = tbxSenha.Text,
              
            };

            novosAnimes.registerAnime();
        }
    }
}
