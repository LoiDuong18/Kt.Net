using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace bai1.Mode
{
    class BaiMotContext:DbContext
    {
        public BaiMotContext() : base(@"Data Source=DESKTOP-OPUFSBJ\SQLEXPRESS;Initial Catalog=BaiMot;User ID=sa;Password=123")
        {
        }
        public DbSet<LopHoc> lopHocs { get; set; }
        public DbSet<SinhVien> sinhViens { get; set; }
        public DbSet<LopHocPhan> lopHocPhans { get; set; }
        public DbSet<MonHoc> monHocs { get; set; }


    }


}
