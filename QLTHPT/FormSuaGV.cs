﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTHPT
{
    public partial class FormSuaGV : Form
    {
        public FormSuaGV(string manv, int index, DataGridView datagv)
        {
            InitializeComponent();
            txt_magv.Text = datagv.Rows[index].Cells[0].Value.ToString();
            txt_hoten.Text = datagv.Rows[index].Cells[1].Value.ToString();
            txt_sdt.Text = datagv.Rows[index].Cells[2].Value.ToString();
            txt_chuyenmon.Text = datagv.Rows[index].Cells[3].Value.ToString();
            txt_gioitinh.Text = datagv.Rows[index].Cells[4].Value.ToString();
            txt_noisinh.Text = datagv.Rows[index].Cells[5].Value.ToString();
            txt_magv.Enabled = false;
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            SqlConnection conn = constringsql.getConnection();
            conn.Open();
            string strQueryDanhSach = "UPDATE dbo.GIAOVIEN SET HOTEN=@HOTEN,SODIENTHOAI=@SODIENTHOAI,CHUYENMON=@CHUYENMON," +
                "GIOITINH=@GIOITINH,NOISINH=@NOISINH WHERE MAGIAOVIEN = @MAGV ";
            SqlCommand comm = new SqlCommand(strQueryDanhSach);
            comm.Connection = conn;
            comm.Parameters.AddWithValue("@MAGV", txt_magv.Text);
            comm.Parameters.AddWithValue("@HOTEN", txt_hoten.Text);
            comm.Parameters.AddWithValue("@GIOITINH", txt_gioitinh.Text);
            comm.Parameters.AddWithValue("@NOISINH", txt_noisinh.Text);
            comm.Parameters.AddWithValue("@CHUYENMON", txt_chuyenmon.Text);
            comm.Parameters.AddWithValue("@SODIENTHOAI", txt_sdt.Text);
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sửa thành công!", "Thông báo!");
            
            Formgiaovien f = new Formgiaovien();
            f.Show();
            this.Close();
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formgiaovien fgv = new Formgiaovien();
            fgv.ShowDialog();
        }

        private void FormSuaGV_Load(object sender, EventArgs e)
        {

        }
    }
}
