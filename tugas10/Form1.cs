using MySqlConnector;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace tugas10
{
    public partial class AplikasiPendaftaranMahasiswa : Form
    {

        private void AplikasiPendaftaranMahasiswa_Load(object sender, EventArgs e)
        {

            string connectionString = "server=localhost;user = root;database = Pendaftaran_Mahasiswa";
            string query = "SELECT * FROM MataKuliah";
            string query2 = "SELECT * FROM Mahasiswa";
            string query3 = "SELECT * FROM Jurusan";
            string query4 = "SELECT * FROM Pendaftaran";
            DataTable dataTable = new DataTable();


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            dataGridViewMataKuliah.DataSource = dataTable;


            using (MySqlConnection connection2 = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(query2, connection2))
            {
                connection2.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            dataGridViewMahasiswa.DataSource = dataTable;

            using (MySqlConnection connection3 = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(query3, connection3))
            {
                connection3.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            dataGridViewJurusan.DataSource = dataTable;

            using (MySqlConnection connection4 = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(query4, connection4))
            {
                connection4.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            dataGridViewData.DataSource = dataTable;
        }
        public AplikasiPendaftaranMahasiswa()
        {
            InitializeComponent();
        }

       
        private void btnmatkul_Click_1(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user = root;database = Pendaftaran_Mahasiswa";
            string query = "SELECT * FROM MataKuliah";
            MySqlConnection connection = new MySqlConnection(connectionString);
            DataTable ds = new DataTable();
            connection.Open();
            using (MySqlDataAdapter a = new MySqlDataAdapter(query, connection))
            {
                a.Fill(ds);
                MessageBox.Show("Berhasil");
            }
            dataGridViewMataKuliah.DataSource = ds;
        }

        private void btnmahasiswa_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user = root;database = Pendaftaran_Mahasiswa";
            string query2 = "SELECT * FROM Mahasiswa";
            MySqlConnection connection2 = new MySqlConnection(connectionString);
            DataTable ds = new DataTable();
            connection2.Open();
            using (MySqlDataAdapter a = new MySqlDataAdapter(query2, connection2))
            {
                a.Fill(ds);
                MessageBox.Show("Berhasil");
            }
            dataGridViewMahasiswa.DataSource = ds;
        }

        private void dataGridViewMahasiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnjurusan_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user = root;database = Pendaftaran_Mahasiswa";
            string query3 = "SELECT * FROM Jurusan";
            MySqlConnection connection3 = new MySqlConnection(connectionString);
            DataTable ds = new DataTable();
            connection3.Open();
            using (MySqlDataAdapter a = new MySqlDataAdapter(query3, connection3))
            {
                a.Fill(ds);
                MessageBox.Show("Berhasil");
            }
            dataGridViewJurusan.DataSource = ds;
        }

        private void btnpendaftaran_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user = root;database = Pendaftaran_Mahasiswa";
            string query4 = "SELECT * FROM Pendaftaran";
            MySqlConnection connection4 = new MySqlConnection(connectionString);
            DataTable ds = new DataTable();
            connection4.Open();
            using (MySqlDataAdapter a = new MySqlDataAdapter(query4, connection4))
            {
                a.Fill(ds);
                MessageBox.Show("Berhasil");
            }
            dataGridViewData.DataSource = ds;
        }

        private void AplikasiPendaftaranMahasiswa_Load_1(object sender, EventArgs e)
        {

        }
    }
}
