using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysinhvien.Models
{
    public class sinhvien
    {
        public virtual int ID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Diachi { get; set; }
        public virtual string  Lophoc { get; set; }
        public virtual DateTime Ngaysinh { get; set; }

    }
}
