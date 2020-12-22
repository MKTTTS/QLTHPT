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

namespace QLTHPT
{
    public partial class Formgiaovien : Form
    {
        DataTable dtDanhSach;
        string magiaovien;
        string tengiaovien;
        public Formgiaovien()
        {
            InitializeComponent();
            dgvGiaoVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public void ReloadForm(SqlConnection conn)
        {
            conn = constringsql.getConnection();
            conn.Open();
            string strQueryDanhSach = "Select MaNhanVien as Mã, HoTen as [Họ và tên], " +
                "NgaySinh as [Ngày Sinh], DiaChi as [Địa Chỉ], SoDienThoai as [Số Điện Thoại], Email, " +
                "Luong as [Lương], TenChucVu AS [Tên chức vụ] from NhanVien, dbo.ChucVu " +
                "WHERE ChucVu.MaChucVu = NhanVien.MaChucVu";
            SqlDataAdapter da = new SqlDataAdapter(strQueryDanhSach, conn);
            dtDanhSach = new DataTable();
            da.Fill(dtDanhSach);
            dgvGiaoVien.DataSource = dtDanhSach;
            conn.Close();
        }

        private void Formgiaovien_Load(object sender, EventArgs e)
        {
            SqlConnection conn = constringsql.getConnection();
            conn.Open();
            string strQueryDanhSach = "SELECT MAGIAOVIEN AS [MÃ GIÁO VIÊN], HOTEN AS [HỌ TÊN], SODIENTHOAI AS [ĐIỆN THOẠI]" +
                                        ", CHUYENMON AS[MÔN HỌC], GIOITINH AS[GIỚI TÍNH], NOISINH AS[NƠI SINH]  FROM dbo.GIAOVIEN";
            SqlDataAdapter da = new SqlDataAdapter(strQueryDanhSach, conn);
            DataTable dtDanhSach = new DataTable();
            da.Fill(dtDanhSach);
            dgvGiaoVien.DataSource = dtDanhSach;
            conn.Close();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            FormTimKiem form = new FormTimKiem();
            form.Show();
            this.Hide();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemGV form = new FormThemGV();
            form.Show();
            this.Hide();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int selectRow = dgvGiaoVien.SelectedRows[0].Index;
            if (selectRow >= 0 && selectRow < dgvGiaoVien.RowCount - 1)
            {
                string magv = dgvGiaoVien.Rows[selectRow].Cells[0].Value.ToString();
                FormSuaGV formSuagv = new FormSuaGV(magv, selectRow, dgvGiaoVien);
                formSuagv.Show();
                this.Dispose();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = constringsql.getConnection();
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn xóa giáo viên : " + tengiaovien, "Xóa giáo viên",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                conn.Open();
                string query = "DELETE FROM [dbo].[GIAOVIEN] WHERE MAGIAOVIEN = " + "'" + magiaovien + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.SelectCommand.ExecuteNonQuery();

                string strQueryDanhSach = "SELECT MAGIAOVIEN AS [MÃ GIÁO VIÊN], HOTEN AS [HỌ TÊN], SODIENTHOAI AS [ĐIỆN THOẠI]" +
                                            ", CHUYENMON AS[MÔN HỌC], GIOITINH AS[GIỚI TÍNH], NOISINH AS[NƠI SINH]  FROM dbo.GIAOVIEN";
                SqlDataAdapter da = new SqlDataAdapter(strQueryDanhSach, conn);
                dtDanhSach = new DataTable();
                da.Fill(dtDanhSach);
                dgvGiaoVien.DataSource = dtDanhSach;
                conn.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection conn = constringsql.getConnection();
            conn.Open();
            if (e.RowIndex < 6 && e.RowIndex >= 0)
            {
                string magv = dgvGiaoVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                tengiaovien = dgvGiaoVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                magiaovien = magv;
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
