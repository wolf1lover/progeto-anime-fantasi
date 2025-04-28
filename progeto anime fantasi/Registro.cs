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
            //recomendação criar váriaveis para componentesm, pq? Para tornar o código flexivel e limpo
            string nomeUsuario = tbxNome.Text;
            string senhaUsuario = tbxSenha.Text;

            if (nomeUsuario == "" || tbxSenha.Text == "")
            {
                MessageBox.Show("Por favor, preencha o campo do Usuário ou Senha!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                DataTable usuario = Usuario.GetUsuario(nomeUsuario, senhaUsuario);
                //MessageBox.Show(nomeUsuario);
                //MessageBox.Show(senhaUsuario);


                if (usuario.Rows.Count > 0)
                {
                    //Saber se o banco de dados foi acessado
                    MessageBox.Show("Login feito com sucesso", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    catalogo_de_animes catalogo_de_animes = new catalogo_de_animes();
                    catalogo_de_animes.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Login não encontrado", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void lblRegistro_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void lblREGISTRAR_Click(object sender, EventArgs e)
        {
            Usuario registerUsuario = new Usuario()
            {
                Nome = tbxNome.Text,
                Senha = tbxSenha.Text,
              
            };

            registerUsuario.registerUsuario();
        }
    }
}
