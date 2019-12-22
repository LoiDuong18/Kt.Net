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
    public partial class ThemLHP : Form
    {
        string maMonHoc;
        List<MonHoc> dsMoHoc = MonHocService.getlistSV();
        List<LopHocPhan> dsLopHocPhan = LopHocPhanService.getListHP();
        public ThemLHP()
        {
            InitializeComponent();
           
            themMaMH.DataSource = dsMoHoc;
            themMaMH.DisplayMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int j = 0;
           foreach(LopHocPhan i in dsLopHocPhan)
            {
                if (i.Id == ThemMaHP.Text)
                {
                    MessageBox.Show("Học Phần Đã Tồn Tại");
                    j = 1;
                    break;
                }

            }
            if (j == 0)
            {
                LopHocPhanService.addData(ThemMaHP.Text, themGiaoVien.Text, themHanMuc.Text, themMaMH.Text);
                this.Close();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
