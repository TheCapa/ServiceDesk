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
    public partial class Esqueci_Senha : Form
    {
        public Esqueci_Senha()
        {
            InitializeComponent();
        }

        private void pnlMudarSenha_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Esqueci_Senha_Load(object sender, EventArgs e)
        {
            
        }

        

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            string conect = @"Server = localhost\DB_SERVICEDESK; Database = SERVICEDESK; Uid = sa; Pwd = N0taLL0w3ds3v1c3d3sk";
            SqlConnection conexao = new SqlConnection(conect);
            SqlCommand query = new SqlCommand();
            query.Connection = conexao;
            conexao.Open();

            if (txtNovaSenha.Text == txtDigiteNovamente.Text)
            {

                query.CommandText = "UPDATE SERVICEDESK.PESSOA SET SENHA = '" + txtDigiteNovamente.Text + "' WHERE NOME_PESSOA = '" + lblNome.Text + "' AND ID_PESSOA = '" + lblID_User.Text + "';";

                SqlDataAdapter dados = new SqlDataAdapter(query);


                query.ExecuteNonQuery();

                conexao.Close();

                MessageBox.Show("Alterada Com Sucesso!!");

                this.Close();
            }

            else
            {
                MessageBox.Show("Insira a Mesma Senha!!");
            }

        }

       
        private void btnProximo_Click_2(object sender, EventArgs e)
        {
            try
            {
                string conect = @"Server = localhost\DB_SERVICEDESK; Database = SERVICEDESK; Uid = sa; Pwd = N0taLL0w3ds3v1c3d3sk";
                SqlConnection conexao = new SqlConnection(conect);
                SqlCommand query = new SqlCommand();
                query.Connection = conexao;
                conexao.Open();




                query.CommandText = "SELECT ID_PESSOA FROM SERVICEDESK.PESSOA WHERE NOME_PESSOA = '" + txtNome.Text + "' AND ID_PESSOA = '" + txtID.Text + "' AND GESTOR = '" + txtGestor.Text + "' AND ID_FUNCAO = '" + txtFuncao.Text + "'";

                SqlDataAdapter dados = new SqlDataAdapter(query);

                object funcao = query.ExecuteScalar();

                query.CommandText = "SELECT NOME_PESSOA FROM SERVICEDESK.PESSOA WHERE NOME_PESSOA = '" + txtNome.Text + "' AND ID_PESSOA = '" + txtID.Text + "'";

                SqlDataAdapter users = new SqlDataAdapter(query);
                object userr = query.ExecuteScalar();
                query.ExecuteNonQuery();

                query.CommandText = "SELECT ID_PESSOA FROM SERVICEDESK.PESSOA WHERE ID_PESSOA = '" + txtID.Text + "' AND NOME_PESSOA = '" + txtNome.Text + "'";

                SqlDataAdapter userids = new SqlDataAdapter(query);
                object userid = query.ExecuteScalar();

                query.ExecuteNonQuery();

                conexao.Close();
                funcao.ToString();

                pnlMudarSenha.Visible = false;

                lblNome.Text = userr.ToString();
                lblID_User.Text = userid.ToString();
            }

            catch
            {
                MessageBox.Show("Insira Os Dados Corretos!!");

            }
        }
    }
}
