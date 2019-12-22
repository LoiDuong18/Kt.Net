using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1.Mode
{
    class SinhVien
    {
        [Key]
        public string Id { get; set; }
        public string ten { get; set; }
        public string hoDem { get; set; }
        public DateTime ngaySinh { get; set; }
        public string diaChi { get; set; }

    }
}


