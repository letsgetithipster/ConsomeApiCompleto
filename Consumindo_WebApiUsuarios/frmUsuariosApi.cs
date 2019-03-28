using System;
using System.Windows.Forms;

namespace Consumindo_WebApiUsuarios
{
    public partial class frmUsuariosApi : Form
    {
        public frmUsuariosApi()
        {
            InitializeComponent();
        }

        string uri = string.Empty;
        int codigoUsuario = 1;

        private async void btnObterUsuarios_Click(object sender, EventArgs e)
        {
            uri = txtUri.Text;
            dgvDados.DataSource = await ConsomeApi.GetUsuarios(uri);
        }

        private async void btnUsuarioPorId_Click(object sender, EventArgs e)
        {
            var bindingSource = new BindingSource();
            InputBox();
            uri = txtUri.Text;            

            if (codigoUsuario != -1)
            {
                uri = $"{txtUri.Text}/{codigoUsuario}";
                bindingSource.DataSource = await ConsomeApi.GetUsuariosById(uri);
                dgvDados.DataSource = bindingSource;
            }
        }

        private void btnIncluirUsuario_Click(object sender, EventArgs e)
        {
            uri = txtUri.Text;

            var usuario = new Usuario()
            {
                Nome = "Lucia",
                Senha = "vitoria",
                Email = "@terra.com"
            };

            ConsomeApi.AddUsuario(uri, usuario);

            MessageBox.Show("Usuário inserido com sucesso.", "Sucesso.");
        }

        private void btnAtualizarUsuario_Click(object sender, EventArgs e)
        {
            InputBox();
            uri = $"{txtUri.Text}/{codigoUsuario}";

            if (codigoUsuario != -1)
            {
                var usuario = new Usuario()
                {
                    UsuarioId = codigoUsuario,
                    Nome = "Lucia",
                    Senha = "vitoria",
                    //campo alterado
                    Email = "$$$$$$$$$$$"
                };

                try
                {
                    ConsomeApi.UpdateUsuario(uri, usuario);
                    MessageBox.Show("Usuário atualizado com sucesso", "Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
        }

        private void btnDeletarUsuario_Click(object sender, EventArgs e)
        {
            InputBox();
            uri = txtUri.Text;            

            if (codigoUsuario != -1)
            {
                try
                {
                    ConsomeApi.DeleteUsuario(uri, codigoUsuario);
                    MessageBox.Show("Usuário deletado com sucesso.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
        }

        private void InputBox()
        {
            string prompt = "Informe o código do Usuário.";
            string titulo = ".Net Core";
            string resultado = Microsoft.VisualBasic.Interaction.InputBox(prompt, titulo, "9", 600, 350);
           
            if (string.IsNullOrEmpty(resultado))
                codigoUsuario = -1;
            else
                codigoUsuario = Convert.ToInt32(resultado);
        }
    }
}
