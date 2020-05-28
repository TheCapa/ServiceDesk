using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Service_Desk
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

         private void formLogin_Load(object sender, EventArgs e)
        {

        }

//        
        public Boolean validar()
        {
          if (txtUsuario.Text == String.Empty && txtSenha.Text == String.Empty)
             {
                 MessageBox.Show("Informe Usuário e Senha.");
                 txtUsuario.Focus();
                 return false;
             }

             else if (txtUsuario.Text == String.Empty)
             {
                 MessageBox.Show("Informe o Usuário.");
                 txtUsuario.Focus();
                 return false;
             }

             else if (txtSenha.Text == String.Empty)
             {
                 MessageBox.Show("Informe a Senha.");
                 txtSenha.Focus();
                 return false;
             }

             return true;
        }
        
           
        public void limpar()
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            if (validar())
            {
                try
                {


                    string conf = @"Server = localhost\DB_SERVICEDESK; Database = SERVICEDESK; Uid = sa; Pwd = N0taLL0w3ds3v1c3d3sk";

                    SqlConnection conexao = new SqlConnection(conf);
                    SqlCommand query = new SqlCommand();
                    query.Connection = conexao;
                    conexao.Open();

                    query.CommandText = "SELECT ID_FUNCAO FROM SERVICEDESK.PESSOA WHERE ID_PESSOA = '" + txtUsuario.Text + "' AND SENHA = '" + txtSenha.Text + "'";


                    SqlDataAdapter dados = new SqlDataAdapter(query);

                    object funcao = query.ExecuteScalar();

                    query.CommandText = "SELECT ID_PESSOA FROM SERVICEDESK.PESSOA WHERE ID_PESSOA = '" + txtUsuario.Text + "' AND SENHA = '" + txtSenha.Text + "'";

                    SqlDataAdapter users = new SqlDataAdapter(query);
                    object userr = query.ExecuteScalar();

                    query.ExecuteNonQuery();

                    conexao.Close();

                    string user = userr.ToString();

                    string local = funcao.ToString();

                    if (local == "1")
                    {

                        string USERs = user[0].ToString();
                        limpar();
                        Form abrir_servicedesk = new ServiceDeskGerenciador(USERs);
                        abrir_servicedesk.ShowDialog();
                    }

                    else
                    {
                        string USERs1 = user[0].ToString();
                        limpar();
                        Form abrir_UserForm = new UserForm(USERs1);
                        abrir_UserForm.ShowDialog();
                    }


                }

                catch
                {
                    MessageBox.Show("Falha na conexão com o banco de dados!!");
                }
            }
        
        }

        private void linkEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form Esqueci_senha = new Esqueci_Senha();
            Esqueci_senha.ShowDialog();
        }
     }

       
}

