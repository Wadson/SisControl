using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SisControl.MUI
{
    public partial class FrmRecuperarSenhaOffline : SisControl.FrmModeloForm
    {   

        public FrmRecuperarSenhaOffline()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Busca o usuário no banco de dados com base no CPF e na data de nascimento.
        /// Pressupõe que a tabela Usuario possui as colunas CPF e DataNascimento.
        /// </summary>
        private Usuario ObterUsuarioPorCPFDataNascimento(string cpf, DateTime dataNascimento)
        {
            Usuario usuario = null;
            using (var con = Conexao.Conex())
            {
                string query = "SELECT UsuarioID, Email FROM Usuario WHERE CPF = @CPF AND DataNascimento = @DataNascimento";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CPF", cpf);
                    cmd.Parameters.AddWithValue("@DataNascimento", dataNascimento);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        usuario = new Usuario
                        {
                            UsuarioID = Convert.ToInt32(reader["UsuarioID"]),
                            Email = reader["Email"].ToString()
                        };
                    }
                    con.Close();
                }
            }
            return usuario;
        }

        /// <summary>
        /// Gera uma senha temporária de 8 caracteres.
        /// </summary>
        private string GerarNovaSenha()
        {
            const string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder senha = new StringBuilder();
            Random rnd = new Random();
            for (int i = 0; i < 8; i++)
            {
                senha.Append(caracteres[rnd.Next(caracteres.Length)]);
            }
            return senha.ToString();
        }

        /// <summary>
        /// Atualiza a senha do usuário no banco de dados, salvando o hash da nova senha.
        /// </summary>
        private bool AtualizarSenhaUsuario(int usuarioID, string novaSenha)
        {
            bool sucesso = false;
            string hashSenha = GerarHashSHA256(novaSenha);

            using (var con = Conexao.Conex())
            {
                string query = "UPDATE Usuario SET Senha = @Senha WHERE UsuarioID = @UsuarioID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Senha", hashSenha);
                    cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    sucesso = rows > 0;
                    con.Close();
                }
            }
            return sucesso;
        }

        /// <summary>
        /// Gera o hash SHA256 para a senha informada.
        /// </summary>
        private string GerarHashSHA256(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecuperarSenha_Click(object sender, EventArgs e)
        {
            string cpf = txtCPF.Text.Trim();
            DateTime dataNascimento = dtpDataNascimento.Value.Date; // Obtém apenas a data

            // Busca o usuário baseado no CPF e na data de nascimento
            Usuario usuario = ObterUsuarioPorCPFDataNascimento(cpf, dataNascimento);
            if (usuario != null)
            {
                // Gerar nova senha temporária
                string novaSenha = GerarNovaSenha();

                // Atualizar senha no banco (armazenando o hash da nova senha)
                if (AtualizarSenhaUsuario(usuario.UsuarioID, novaSenha))
                {
                    lblNovaSenha.Visible = true;
                    lblNovaSenhaRotulo.Visible = true;
                    lblNovaSenha.Text = novaSenha;
                    // Exibir a nova senha diretamente no formulário
                    MessageBox.Show("Sua nova senha é: " + novaSenha + "\nRecomendamos que a altere após o primeiro acesso.",
                                    "Recuperação de Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar a senha no sistema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("CPF ou Data de Nascimento não encontrados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    /// <summary>
    /// Classe para representar os dados mínimos de um usuário para esse processo.
    /// </summary>
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string Email { get; set; }
    }
}
