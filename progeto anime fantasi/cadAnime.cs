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
    public partial class cadAnime : Form
    {
        public cadAnime()
        {
            InitializeComponent();
        }

        private void btnDELETAR_Click(object sender, EventArgs e)
        {

            Usuario usuarioRemovido = new Usuario()
            {
                IDAnime = Convert.ToInt32(tbxIDAnime.Text)
            };

            usuarioRemovido.deleteAnime();
        }

        private void btnATUALIZAR_Click_1(object sender, EventArgs e)
        {
            Usuario usuarioAtualizado = new Usuario()
            {
                IDregistro = Convert.ToInt32(tbxIDAnime.Text),
                ImagemAnime = tbxImagemAnime.Text,
                NomeAnime = tbxNomeAnime.Text,
                DataLancamentoAnime = tbxDataLancamento.Text,
                AvaliacaoAnime = tbxAvaliacao.Text,
                EpisodiosAnime = tbxEpisodios.Text,
                AnimeCategoria = tbxCategoria.Text,
            };

            usuarioAtualizado.registerAnime();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            Usuario novosAnimes = new Usuario()
            {
                ImagemAnime = tbxImagemAnime.Text,
                NomeAnime = tbxNomeAnime.Text,
                DataLancamentoAnime = tbxDataLancamento.Text,
                AvaliacaoAnime = tbxAvaliacao.Text,
                EpisodiosAnime = tbxEpisodios.Text,
                AnimeCategoria = tbxCategoria.Text,
            };

            novosAnimes.registerAnime();
        }

        private void lblCategoria_Click(object sender, EventArgs e)
        {

        }

        private void lblNomeAnime_Click(object sender, EventArgs e)
        {

        }
    }
}
