using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bai1.Mode;
using bai1.Service;

namespace bai1
{
    public partial class Form1 : Form
    {
        List<SinhVien> dsSinhVien = SinhVienService.getlistSV();
        List<LopHocPhan> lopHocPhan = LopHocPhanService.getListHP();
        List<MonHoc> monHoc = MonHocService.getlistSV();
     

        public Form1()
        {
            InitializeComponent();
            comboMonHoc.DataSource = monHoc;
            comboMonHoc.DisplayMember = "Id";           
        }
        public void Load()
        {
            List<LopHocPhan> LHP = LopHocPhanService.tim(comboMonHoc.Text);
            viewHocPhan.DataSource = LHP;
        }
        private void comboMonHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            Load();
        }
        
        private void comboMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        string maLop, maMonHoc;
        //click chon item dataGitView
        private void viewHocPhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            
            DataGridViewRow row = viewHocPhan.Rows[e.RowIndex];
            maLop= row.Cells[0].Value + "";
            textMaLop.Text = maLop;
            textDinhMuc.Text = row.Cells[2].Value + "";
            textGiaoVien.Text = row.Cells[1].Value + "";
            maMonHoc = row.Cells[3].Value + "";
            List<SinhVien> dsSinhVien1 = SinhVienService.getlistTimSV(maLop);
            viewSinhVien.DataSource = dsSinhVien1;
            textSoLuong.Text = dsSinhVien1.Count().ToString();
        }
        //Thêm
        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            string mh = comboMonHoc.Text;
            ThemLHP themLHP = new ThemLHP();
            themLHP.ShowDialog();
            Load();
        }
        //Dăng Kí
        private void toolStripLabel7_Click(object sender, EventArgs e)
        {
            DangKi dk = new DangKi(maLop);
            dk.ShowDialog();
            Load();
        }
        //Xóa
        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bạn có muốn xóa "+ maLop);
            LopHocPhanService.delete(maLop);
            Load();
        }
        string maSV, maMH;
        private void toolStripLabel8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bạn muốn xóa");
            LopHocService.delete(maMH, maSV);
            List<SinhVien> dsSinhVien1 = SinhVienService.getlistTimSV(maLop);
            viewSinhVien.DataSource = dsSinhVien1;
        }

        private void viewSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = viewSinhVien.Rows[e.RowIndex];
            maSV = row.Cells[0].Value + "";
            maMH = textMaLop.Text;
           
        }

        //sửa
        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            LopHocPhan lhp = new LopHocPhan();
            lhp.Id = maLop;
            lhp.maMonHoc = maMonHoc;
            lhp.giaoVienPhuTrach = textGiaoVien.Text;
            lhp.hanMucSinhVien = textDinhMuc.Text;
            LopHocPhanService.edit(lhp);
            Load();
        }
    }
}
