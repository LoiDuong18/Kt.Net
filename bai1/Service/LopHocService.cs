using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bai1.Mode;

namespace bai1.Service
{
    class LopHocService
    {
        public static List<LopHoc> getList()
        {
            return new BaiMotContext().lopHocs.ToList();
        }
        public static void addData(string malHP, string maSV)
        {
            var db = new BaiMotContext();
            LopHoc lh = new LopHoc();
            lh.maLopHocPhan = malHP;
            lh.maSinhVien = maSV;
            db.lopHocs.Add(lh);
            db.SaveChanges();
        }
        public static void delete(string maHP, string maSV)
        {
            var db = new BaiMotContext();
            var dataHP = db.lopHocs.Where(e => e.maSinhVien==maSV && e.maLopHocPhan==maHP).FirstOrDefault();
            db.lopHocs.Remove(dataHP);
            db.SaveChanges();
        }
        
    }
}
