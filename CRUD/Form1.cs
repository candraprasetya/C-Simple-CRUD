using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace CRUD
{
    public partial class Form1 : Form
    {
        //Candra Ramadhan Prasetya
        private OleDbConnection _conn;

        public Form1()
        {
            InitializeComponent();
            listnya();
        }
        //Candra Ramadhan Prasetya
        private OleDbConnection GetOpenConnection(string connectionString)
        {
            OleDbConnection conn = null;
            try
            {
                conn = new OleDbConnection(connectionString);
                conn.Open();
            }
            catch
            {
            }
            return conn;
        }
        //Candra Ramadhan Prasetya
        private void populate(String nim, String nama, String angkatan)
        {
            //ROW
            String[] row = { nim, nama, angkatan };

            ListViewItem item = new ListViewItem(row);

            listView1.Items.Add(item);
        }
        private void listnya()
        {
            //LISTVIEW PROPERTIES
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            //ADD COLUMNS
            listView1.Columns.Add("NIM", 100);
            listView1.Columns.Add("NAMA", 150);
            listView1.Columns.Add("ANGKATAN", 100);
        }
        //INSERT INTO DB
        private void add(String name, string pos, string team)
        {
            var result = 0;
            var sql = @"insert into mahasiswa (npm, nama, angkatan)
                        values (@npm, @nama, @angkatan)";

            using (var cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@npm", txtNimCreate.Text);
                cmd.Parameters.AddWithValue("@nama", txtNamaCreate.Text);
                cmd.Parameters.AddWithValue("@angkatan", txtAngkatanCreate.Text);
                result = cmd.ExecuteNonQuery();
            }

        }

        private void Halo()
        {
            var dbName = Directory.GetCurrentDirectory() + "\\DBPerpustakaan.mdb";
            var connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", dbName);
            _conn = GetOpenConnection(connectionString);
            if (_conn.State == ConnectionState.Open)
            {
                MessageBox.Show("Koneksi ke database berhasil !", "Informasi", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                lbl_connection.Text = "You are connected";
            }
            else
            {
                MessageBox.Show("Koneksi ke database gagal !!!", "Informasi", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                lbl_connection.Text = "You are not connected";
                lbl_connection.ForeColor = Color.Red;
            }
        }
        //Candra Ramadhan Prasetya
        private void Form1_Load(object sender, EventArgs e)
        {
            Halo();
            getData();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            var result = 0;
            // validasi npm harus diisi
            if (!txtNimCreate.MaskFull)
            {
                MessageBox.Show("NPM harus diisi !!!", "Informasi", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                txtNimCreate.Focus();
                return;
            }
            // validasi nama harus diisi
            if (txtNamaCreate.Text.Length == 0)
            {
                MessageBox.Show("Nama harus diisi !!!", "Informasi", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                txtNamaCreate.Focus();
                return;
            }
            var sql = @"insert into mahasiswa (npm, nama, angkatan)
                        values (@npm, @nama, @angkatan)";
            using (var cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@npm", txtNimCreate.Text);
                cmd.Parameters.AddWithValue("@nama", txtNamaCreate.Text);
                cmd.Parameters.AddWithValue("@angkatan", txtAngkatanCreate.Text);
                result = cmd.ExecuteNonQuery();
            }
            if (result > 0)
            {
                MessageBox.Show("Data mahasiswa berhasil disimpan !", "Informasi", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                // reset form
                txtNimCreate.Clear();
                txtNamaCreate.Clear();
                txtAngkatanCreate.Clear();
                txtNimCreate.Focus();
            }
            else
                MessageBox.Show("Data mahasiswa gagal disimpan !!!", "Informasi", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }
        
        private void getData()
        {
            listDataRead.Items.Clear();
            var sql = @"select npm, nama, angkatan
                    from mahasiswa
                    order by nama";
            using (var cmd = new OleDbCommand(sql, _conn))
            {
                using (var dtr = cmd.ExecuteReader())
                {
                    var noUrut = 1;
                    while (dtr.Read())
                    {
                        var data = string.Format("{0}. {1}, {2}, {3}",
                        noUrut, dtr["npm"].ToString(), dtr["nama"].ToString(),
                        dtr["angkatan"].ToString());
                        listDataRead.Items.Add(data);
                        noUrut++;
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            var sql = @"select npm, nama, angkatan from mahasiswa where npm = @npm";
            using (var cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@npm", txtNimUpdate.Text);
                using (var dtr = cmd.ExecuteReader())
                {
                    if (dtr.Read())
                    {
                        txtNimUpdate.Text = dtr["npm"].ToString();
                        txtNamaUpdate.Text = dtr["nama"].ToString();
                        txtAngkatanUpdate.Text = dtr["angkatan"].ToString();
                    }
                    else
                        MessageBox.Show("Data mahasiswa tidak ditemukan !", "Informasi", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var result = 0;
            // validasi npm harus diisi
            if (!txtNimUpdate.MaskFull)
            {
                MessageBox.Show("NPM harus !!!", "Informasi", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                txtNimUpdate.Focus();
                return;
            }
            // validasi nama harus diisi
            if (txtNamaUpdate.Text.Length == 0)
            {
                MessageBox.Show("Nama harus !!!", "Informasi", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                txtNamaUpdate.Focus();
                return;
            }
            var sql = @"update mahasiswa set nama = @nama, angkatan = @angkatan
where npm = @npm";
            using (var cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@nama", txtNamaUpdate.Text);
                cmd.Parameters.AddWithValue("@angkatan", txtAngkatanUpdate.Text);
                cmd.Parameters.AddWithValue("@npm", txtNimUpdate.Text);
                result = cmd.ExecuteNonQuery();
            }
            if (result > 0)
            {
                MessageBox.Show("Data mahasiswa berhasil diupdate !", "Informasi", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                // reset form
                txtNimUpdate.Clear();
                txtNamaUpdate.Clear();
                txtAngkatanUpdate.Clear();
                txtNimUpdate.Focus();
            }
            else
                MessageBox.Show("Data mahasiswa gagal diupdate !!!", "Informasi", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }

        private void btnFindDelete_Click(object sender, EventArgs e)
        {
            var sql = @"select npm, nama, angkatan
from mahasiswa
where npm = @npm";
            using (var cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@npm", txtNimDelete.Text);
                using (var dtr = cmd.ExecuteReader())
                {
                    if (dtr.Read())
                    {
                        txtNimDelete.Text = dtr["npm"].ToString();
                        txtNamaDelete.Text = dtr["nama"].ToString();
                        txtAngkatanDelete.Text = dtr["angkatan"].ToString();
                    }
                    else
                        MessageBox.Show("Data mahasiswa tidak ditemukan !", "Informasi", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = 0;
            // validasi npm harus diisi
            if (!txtNimDelete.MaskFull)
            {
                MessageBox.Show("NPM harus !!!", "Informasi", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                txtNimDelete.Focus();
                return;
            }
            // validasi nama harus diisi
            if (txtNamaDelete.Text.Length == 0)
            {
                MessageBox.Show("Nama harus !!!", "Informasi", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                txtNamaDelete.Focus();
                return;
            }
            var sql = @"delete from mahasiswa where npm = @npm";

           
            using (var cmd = new OleDbCommand("DELETE FROM mahasiswa WHERE npm ='" + txtNimDelete.Text +"'", _conn))                
            {
                result = cmd.ExecuteNonQuery();
            }
            if (result > 0)
            {
                MessageBox.Show("Data mahasiswa berhasil dihapus !", "Informasi", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                // reset form
                txtNimDelete.Clear();
                txtNamaDelete.Clear();
                txtAngkatanDelete.Clear();
                txtNimDelete.Focus();
            }
            else
                MessageBox.Show("Data mahasiswa gagal dihapus !!!", "Informasi", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
