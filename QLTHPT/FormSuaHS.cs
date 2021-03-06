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
    public partial class FormSuaHS : Form
    {
        public FormSuaHS(string mahs, int index, DataGridView datahs)
        {
            InitializeComponent();
            txt_mahs.Text = datahs.Rows[index].Cells[0].Value.ToString();
            txt_hoten.Text = datahs.Rows[index].Cells[1].Value.ToString();
            txt_gioitinh.Text = datahs.Rows[index].Cells[2].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(datahs.Rows[index].Cells[3].Value.ToString());
            txt_quequan.Text = datahs.Rows[index].Cells[4].Value.ToString();
            txt_mahs.Enabled = false;
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            SqlConnection conn = constringsql.getConnection();
            conn.Open();
            string strQueryDanhSach = "UPDATE dbo.HOCSINH SET HOTEN=@HOTEN,GIOITINH=@GIOITINH,NGAYSINH=@NGAYSINH,NOISINH=@NOISINH" +
                " WHERE MAHOCSINH = @MAHOCSINH  ";
            SqlCommand comm = new SqlCommand(strQueryDanhSach);
            comm.Connection = conn;
            comm.Parameters.AddWithValue("@MAHOCSINH", txt_mahs.Text);
            comm.Parameters.AddWithValue("@HOTEN", txt_hoten.Text);
            comm.Parameters.AddWithValue("@GIOITINH", txt_gioitinh.Text);
            //comm.Parameters.AddWithValue("@NGAYSINH", dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            comm.Parameters.AddWithValue("@NGAYSINH", dateTimePicker1.Value.ToShortDateString());
            comm.Parameters.AddWithValue("@NOISINH", txt_quequan.Text);
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sửa thành công!", "Thông báo!");
            this.Close();
            Formhocsinh f = new Formhocsinh();
            f.Show();
            this.Close();
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formhocsinh fhs = new Formhocsinh();
            fhs.ShowDialog();
        }

        private void txt_quequan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
