using bai1.Mode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1.Service
{
    class SinhVienService
    {
        public static List<SinhVien> getlistSV()
        {
            return new BaiMotContext().sinhViens.ToList();
        }
        public static List<LopHoc> getlistSVLopHoc()
        {
            return new BaiMotContext().lopHocs.ToList();
        }
        public static List<SinhVien> getlistTimSV(string id)
        {
            List<SinhVien> sv = new List<SinhVien>();
            foreach (LopHoc i in getlistSVLopHoc())
            {
               
                if (i.maLopHocPhan == id)
                {
                    foreach(SinhVien j in getlistSV())
                    {
                        if (j.Id == i.maSinhVien)
                        {
                            sv.Add(j);
                            break;
                        }
                    }
                }
            }
            return sv;

        }
    }
}
