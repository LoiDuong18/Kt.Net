using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bai1.Mode;

namespace bai1.Service
{
    class MonHocService
    {
        public static List<MonHoc> getlistSV()
        {
            return new BaiMotContext().monHocs.ToList();
        }
    }
}
