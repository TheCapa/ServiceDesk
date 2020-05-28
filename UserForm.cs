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
    public partial class UserForm : Form
    {

         public UserForm()
        {
            InitializeComponent();
        }

        public string USERs1;

        public UserForm(string USERs_recebido)
        {
            InitializeComponent();
            USERs1 = USERs_recebido;
        }

     

        private void btnDeslogar_Click(object sender, EventArgs e)
        {
            Form abrir_formLogin = new formLogin();
            abrir_formLogin.ShowDialog();

            Application.Exit();
        }

        private void Nome_Usuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
           
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            string conect = @"Server = localhost\DB_SERVICEDESK; Database = SERVICEDESK; Uid = sa; Pwd = N0taLL0w3ds3v1c3d3sk";
            SqlConnection conexao = new SqlConnection(conect);
            SqlCommand query = new SqlCommand();
            query.Connection = conexao;
            conexao.Open();

            query.CommandText = "SELECT NOME_PESSOA FROM SERVICEDESK.PESSOA WHERE ID_PESSOA ='" + USERs1 + "';";
            SqlDataAdapter dadosNome = new SqlDataAdapter(query);
            object nomeBD = query.ExecuteScalar();
            query.ExecuteNonQuery();
            conexao.Close();
            lblUser_Logado.Text = nomeBD.ToString();
          

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
