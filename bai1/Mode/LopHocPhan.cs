using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1.Mode
{
    class LopHocPhan
    { 
        [Key]
        public string Id { get; set; }
        public string giaoVienPhuTrach { get; set; }
        public string hanMucSinhVien { get; set; }
        public string maMonHoc { get; set; }
    }
}
