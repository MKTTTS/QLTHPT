﻿using System;
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
    public partial class Formhocsinh : Form
    {
        DataTable dtDanhSach;
        string mahocsinh;
        string tenhocsinh;
        public Formhocsinh()
        {
            InitializeComponent();
            dataGridViewHocSinh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void Formhocsinh_Load(object sender, EventArgs e)
        {
            SqlConnection conn = constringsql.getConnection();
            conn.Open();
            string strQueryDanhSach = "SELECT MAHOCSINH AS [MÃ HỌC SINH], HOTEN AS [HỌ TÊN], GIOITINH AS [GIỚI TÍNH]," +
                " NGAYSINH AS [NGÀY SINH], NOISINH AS [QUÊ QUÁN] FROM dbo.HOCSINH";
            SqlDataAdapter da = new SqlDataAdapter(strQueryDanhSach, conn);
            DataTable dtDanhSach = new DataTable();
            da.Fill(dtDanhSach);
            dataGridViewHocSinh.DataSource = dtDanhSach;
            conn.Close();
        }

        private void bt_timkiemhs_Click(object sender, EventArgs e)
        {
            FormTimKiem form = new FormTimKiem();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void Bt_themhs_Click(object sender, EventArgs e)
        {
            FormThem ft = new FormThem();
            ft.Show();
            this.Hide();
        }

        private void Bt_suahs_Click(object sender, EventArgs e)
        {

        }

        private void Bt_xoahs_Click(object sender, EventArgs e)
        {
            SqlConnection conn = constringsql.getConnection();
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn xóa học sinh : " + tenhocsinh, "Xóa học sinh",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                conn.Open();
                string query = "DELETE FROM [dbo].[HOCSINH] WHERE MAHOCSINH = " + "'" + mahocsinh + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.SelectCommand.ExecuteNonQuery();

                string strQueryDanhSach = "SELECT MAHOCSINH AS [MÃ HỌC SINH], HOTEN AS [HỌ TÊN], GIOITINH AS [GIỚI TÍNH], " +
                    "NGAYSINH AS [NGÀY SINH], NOISINH AS [QUÊ QUÁN] FROM dbo.HOCSINH";
                SqlDataAdapter da = new SqlDataAdapter(strQueryDanhSach, conn);
                dtDanhSach = new DataTable();
                da.Fill(dtDanhSach);
                dataGridViewHocSinh.DataSource = dtDanhSach;
                conn.Close();
            }
        }

        private void DataGridViewHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection conn = constringsql.getConnection();
            conn.Open();
            if (e.RowIndex < 6 && e.RowIndex >= 0)
            {
                string mahs = dataGridViewHocSinh.Rows[e.RowIndex].Cells[0].Value.ToString();
                tenhocsinh = dataGridViewHocSinh.Rows[e.RowIndex].Cells[1].Value.ToString();
                mahocsinh = mahs;
            }
            conn.Close();
        }
    }
}
