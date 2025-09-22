using MySql.Data.MySqlClient;
using System.Data;

namespace LatihanXIIRPL1
{
    public partial class FormBuku : Form
    {
        public FormBuku()
        {
            InitializeComponent();
        }
        //membuat method refresh data pada data grid view
        private void refreshData()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=dbperpustakaan;uid=root;pwd=;");
            try
            {
                conn.Open();
                string query = "Select * From buku Order by id desc";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvBuku.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Server Database mysql error : " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=dbperpustakaan;uid=root;pwd=;");

            try
            {
                conn.Open();
                string query = "Insert into buku (isbn,judul,pengarang,penerbit,tahun_terbit) values (@isbn,@judul,@pengarang,@penerbit,@tahun_terbit)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@isbn", txtISBN.Text);
                cmd.Parameters.AddWithValue("@judul", txtJudul.Text);
                cmd.Parameters.AddWithValue("@pengarang", txtPengarang.Text);
                cmd.Parameters.AddWithValue("@penerbit", txtPenerbit.Text);
                cmd.Parameters.AddWithValue("@tahun_terbit", txtTahunTerbit.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Simpan Berhasil!!");
                //REFRESH TERBARU
                refreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Server Database mysql error : " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string isbn = dgvBuku.SelectedRows[0].Cells[1].Value.ToString();
            
            MySqlConnection conn = new MySqlConnection("server=localhost;database=dbperpustakaan;uid=root;pwd=;");
            try
            {
                conn.Open();
                string query = "Delete From buku where isbn = @isbn";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@isbn", isbn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Hapus data Berhasil!!");
                //REFRESH TERBARU
                refreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Server Database mysql error : " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void FormBuku_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        private void dgvBuku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
