using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1.Mode
{
    class MonHoc
    {
        [Key]
        public string id { get; set; }
        public string tenMonHoc { get; set; }
        
    }
}
