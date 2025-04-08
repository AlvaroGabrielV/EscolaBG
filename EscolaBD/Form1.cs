using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using EscolaBD;



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
            listar();

        }


        private void listar()
        {
            MySqlConnection conexaoBD = ConexaoBD.ObterConexao();
            conexaoBD.Open();

            string select = "SELECT id_aluno,nome, DATE_FORMAT(nascimento, '%d/%m/%Y') AS nascimento ,curso ,telefone FROM aluno";
            MySqlCommand comandoSelect = new MySqlCommand(select, conexaoBD);
            MySqlDataReader readerSelect = comandoSelect.ExecuteReader();
            alunosGrid.Rows.Clear();
            while (readerSelect.Read())
            {
                string nome = readerSelect["nome"].ToString();
                string nascimentoStr = readerSelect["nascimento"].ToString();
                DateTime nascimentoData;
                if (!DateTime.TryParseExact(nascimentoStr, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out nascimentoData))
                {
                    nascimentoData = DateTime.MinValue;
                }
                string cursoData = readerSelect["curso"].ToString();
                string telefoneData = readerSelect["telefone"].ToString();
                alunosGrid.Rows.Add(nome, nascimentoData.ToShortDateString(), cursoData, telefoneData);
            }
            readerSelect.Close();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string user = nome_txt.Text;
            DateTime nascimento = Convert.ToDateTime(nascimento_txt.Text.Trim());
            string curso = curso_txt.Text;
            string telefone = telefone_txt.Text;

            MySqlConnection conexaoBD = ConexaoBD.ObterConexao();
            conexaoBD.Open();

            string insert = "INSERT INTO aluno (nome, nascimento, curso, telefone) VALUES (@usuario, @senha, @curso, @telefone)";
            MySqlCommand comandoSQL = new MySqlCommand(insert, conexaoBD);

            comandoSQL.Parameters.AddWithValue("@usuario", user);
            comandoSQL.Parameters.AddWithValue("@senha", nascimento);
            comandoSQL.Parameters.AddWithValue("@curso", curso);
            comandoSQL.Parameters.AddWithValue("@telefone", telefone);
            comandoSQL.ExecuteNonQuery();

            listar();

            nome_txt.Clear();
            nascimento_txt.Clear();
            curso_txt.Clear();
            telefone_txt.Clear();

        }

        private void alunosGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
                if (alunosGrid.CurrentRow != null)
                {
                    string nome = alunosGrid.CurrentRow.Cells["nome"].Value.ToString();
                    string nascimento = alunosGrid.CurrentRow.Cells["nascimento"].Value.ToString();
                    string curso = alunosGrid.CurrentRow.Cells["curso"].Value.ToString();
                    string telefone = alunosGrid.CurrentRow.Cells["telefone"].Value.ToString();

                    nome_txt.Text = nome;
                    nascimento_txt.Text = nascimento;
                    curso_txt.Text = curso;
                    telefone_txt.Text = telefone;

                    nome_txt.Enabled = false;
                    add_btn.Enabled = false;
                    nascimento_txt.Enabled = false;
                }

        }

        private void alter_btn_Click(object sender, EventArgs e)
        {
            string nome = nome_txt.Text;
            string curso = curso_txt.Text;
            string telefone = telefone_txt.Text;

            MySqlConnection conexaoBD = ConexaoBD.ObterConexao();
            conexaoBD.Open();

            string update = "UPDATE aluno SET curso = @curso, telefone = @telefone WHERE nome = @nome";
            MySqlCommand updateSQL = new MySqlCommand(update, conexaoBD);

            updateSQL.Parameters.AddWithValue("@nome", nome);
            updateSQL.Parameters.AddWithValue("@curso", curso);
            updateSQL.Parameters.AddWithValue("@telefone", telefone);
            updateSQL.ExecuteNonQuery();

            MessageBox.Show("Aluno atualizado com sucesso!");

            listar();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string nome = nome_txt.Text;

            MySqlConnection conexaoBD = ConexaoBD.ObterConexao();
            conexaoBD.Open();

            string delete = "DELETE FROM aluno WHERE nome = @nome";
            MySqlCommand deleteSQL = new MySqlCommand(delete, conexaoBD);

            deleteSQL.Parameters.AddWithValue("@nome", nome);
            deleteSQL.ExecuteNonQuery();

            MessageBox.Show("Aluno atualizado com sucesso!");

            listar();
        }
    }
}
