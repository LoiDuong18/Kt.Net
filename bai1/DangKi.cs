using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bai1.Service;
using bai1.Mode;

namespace bai1
{
    public partial class DangKi : Form
    {
        string ma;
        List<SinhVien> dsSV = SinhVienService.getlistSV();
        List<SinhVien> dsSesch;
        public DangKi(string maLHP)
        {
            InitializeComponent();
            ma = maLHP;
            dsSesch = SinhVienService.getlistTimSV(themMaSV.Text);
        }
        
        private void dangKiSV_Click(object sender, EventArgs e)
        {
            
            
            LopHocService.addData(ma, themMaSV.Text);
            this.Close();
        }

        private void huySV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
