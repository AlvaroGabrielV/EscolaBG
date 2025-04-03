using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;


namespace EscolaBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            alunosGrid.Columns.Add("Nome", "Nome");
            alunosGrid.Columns.Add("Nascimento", "Nascimento");
            alunosGrid.Columns.Add("Curso", "Curso");
            alunosGrid.Columns.Add("Telefone", "Telefone");

        
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string user = nome_txt.Text;
            DateTime nascimento = Convert.ToDateTime(nascimento_txt.Text.Trim());
            string curso = curso_txt.Text;
            string telefone = telefone_txt.Text;

            string conexao = "Server=localhost; Database=escola; UID=root; pwd=''";
            MySqlConnection conexaoBD = new MySqlConnection(conexao);
            conexaoBD.Open();

            string insert = "INSERT INTO aluno (nome, nascimento, curso, telefone) VALUES (@usuario, @senha, @curso, @telefone)";
            MySqlCommand comandoSQL = new MySqlCommand(insert,conexaoBD);

            comandoSQL.Parameters.AddWithValue("@usuario", user);
            comandoSQL.Parameters.AddWithValue("@senha", nascimento);
            comandoSQL.Parameters.AddWithValue("@curso", curso);
            comandoSQL.Parameters.AddWithValue("@telefone", telefone);

            MySqlDataReader reader = comandoSQL.ExecuteReader();
        }
    }
}
