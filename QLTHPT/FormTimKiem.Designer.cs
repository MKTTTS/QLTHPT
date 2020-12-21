
namespace QLTHPT
{
    partial class FormTimKiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_back = new System.Windows.Forms.Button();
            this.bt_timkiem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbTimkiemSV = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.cbTimKiemGV = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_back
            // 
            this.bt_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_back.Location = new System.Drawing.Point(214, 457);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(180, 79);
            this.bt_back.TabIndex = 11;
            this.bt_back.Text = "BACK";
            this.bt_back.UseVisualStyleBackColor = false;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_timkiem.Location = new System.Drawing.Point(21, 457);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(187, 79);
            this.bt_timkiem.TabIndex = 10;
            this.bt_timkiem.Text = "TÌM KIẾM";
            this.bt_timkiem.UseVisualStyleBackColor = false;
            this.bt_timkiem.Click += new System.EventHandler(this.bt_timkiem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(433, 30);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1050, 494);
            this.dataGridView1.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbTimKiemGV);
            this.panel1.Controls.Add(this.cbTimkiemSV);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_timkiem);
            this.panel1.Controls.Add(this.bt_back);
            this.panel1.Controls.Add(this.bt_timkiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 579);
            this.panel1.TabIndex = 14;
            // 
            // cbTimkiemSV
            // 
            this.cbTimkiemSV.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbTimkiemSV.FormattingEnabled = true;
            this.cbTimkiemSV.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Address"});
            this.cbTimkiemSV.Location = new System.Drawing.Point(66, 125);
            this.cbTimkiemSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTimkiemSV.Name = "cbTimkiemSV";
            this.cbTimkiemSV.Size = new System.Drawing.Size(267, 29);
            this.cbTimkiemSV.TabIndex = 18;
            this.cbTimkiemSV.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nhập từ khóa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tìm kiếm theo";
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_timkiem.Location = new System.Drawing.Point(66, 293);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(267, 28);
            this.tb_timkiem.TabIndex = 15;
            // 
            // cbTimKiemGV
            // 
            this.cbTimKiemGV.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbTimKiemGV.FormattingEnabled = true;
            this.cbTimKiemGV.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Phone",
            "Address",
            "Speciality"});
            this.cbTimKiemGV.Location = new System.Drawing.Point(66, 125);
            this.cbTimKiemGV.Name = "cbTimKiemGV";
            this.cbTimKiemGV.Size = new System.Drawing.Size(267, 29);
            this.cbTimKiemGV.TabIndex = 19;
            this.cbTimKiemGV.Text = "ID";
            // 
            // FormTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 579);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormTimKiem";
            this.Text = "FormTimKiem";
            this.Load += new System.EventHandler(this.FormTimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.Button bt_timkiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbTimkiemSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.ComboBox cbTimKiemGV;
    }
}