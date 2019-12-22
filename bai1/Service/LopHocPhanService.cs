using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bai1.Mode;

namespace bai1.Service
{
    class LopHocPhanService
    {
        public static List<LopHocPhan> getListHP()
        {
            return new BaiMotContext().lopHocPhans.ToList();
        }
        public static List<LopHocPhan> tim(string id)
        {
            List<LopHocPhan> ds = new List<LopHocPhan>();
            foreach (LopHocPhan i in getListHP())
            {
                if (i.maMonHoc == id)
                    ds.Add(i);
            }
            return ds;
        }
        public static void addData(string id, string giaoVien, string hanMuc, string maMonHoc)
        {
            var db = new BaiMotContext();
            LopHocPhan LHP = new LopHocPhan();
            LHP.Id = id;
            LHP.giaoVienPhuTrach = giaoVien;
            LHP.hanMucSinhVien = hanMuc;
            LHP.maMonHoc = maMonHoc;
            db.lopHocPhans.Add(LHP);
            db.SaveChanges();
        }
        public static void delete(string id)
        {
            var db = new BaiMotContext();
            var dataHP = db.lopHocPhans.Where(e => e.Id == id).FirstOrDefault();
            db.lopHocPhans.Remove(dataHP);
            db.SaveChanges();
        }
        public static void edit(LopHocPhan lhp)
        {
            var db = new BaiMotContext();
            var data = db.lopHocPhans.Where(e => e.Id == lhp.Id).FirstOrDefault();
            data.Id = lhp.Id;
            data.giaoVienPhuTrach = lhp.giaoVienPhuTrach;
            data.hanMucSinhVien = lhp.hanMucSinhVien;
            data.maMonHoc = lhp.maMonHoc;
            db.SaveChanges();
        }
    }
}