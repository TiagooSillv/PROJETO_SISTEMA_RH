using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace iRh.Windows
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        string stringConecxao = "Data Source=TIAGO\\SQL2022;Initial Catalog=dbLogin;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string senha = txtSenha.Text;

            using(SqlConnection conecxao = new SqlConnection(stringConecxao))
            {
                conecxao.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT loginUsuario FROM tblLogin WHERE loginUsuario  = @usuario",conecxao))
                {
                    cmd.Parameters.AddWithValue("@usuario", login);
                    string verificadorDeEmail = cmd.ExecuteScalar() as string ;

                    if (verificadorDeEmail == null)
                    {
                        DialogResult novoCadastro = MessageBox.Show("Email não cadastrado deseja cadastrar um novo!", "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (novoCadastro == DialogResult.Yes)
                        {
                            using (SqlCommand cadastrarUsuario = new SqlCommand("INSERT INTO tblLogin(loginUsuario, senha) VALUES(@usuario,@senha)",conecxao))
                            {
                                cadastrarUsuario.Parameters.AddWithValue("@usuario", login);
                                cadastrarUsuario.Parameters.AddWithValue("@senha", senha);
                                string verificadorDeCadastro =  cadastrarUsuario.ExecuteScalar() as string;

                                MessageBox.Show("Cadastro Realizado com sucesso", "CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.None);

                            }
                        }
                    }
                    else
                    {
                        using (SqlCommand cmdSenha = new SqlCommand("SELECT senha FROM tblLogin WHERE loginUsuario = @login",conecxao))
                        {
                            cmdSenha.Parameters.AddWithValue("@login", login);
                            string verificadorSenha = cmdSenha.ExecuteScalar() as string;

                            if (verificadorSenha == senha)
                            {
                                PrincipalMdi principalMdi = new PrincipalMdi();
                                principalMdi.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Senha Incorreta", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }

        }
    }
}
