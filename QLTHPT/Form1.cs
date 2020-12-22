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
    public partial class Form1 : Form
    {
        public static int chooseGV_Stu = 0;
        // gv =1; hs=2
        SqlConnection conn = constringsql.getConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void pb_gv_Click(object sender, EventArgs e)
        {
            chooseGV_Stu = 1;
            this.Hide();
            Formgiaovien fgv = new Formgiaovien();
            fgv.ShowDialog();
        }

        private void pb_hs_Click(object sender, EventArgs e)
        {
            chooseGV_Stu = 2;
            this.Hide();
            Formhocsinh fhs = new Formhocsinh();
            fhs.ShowDialog();
        }
    }
}
