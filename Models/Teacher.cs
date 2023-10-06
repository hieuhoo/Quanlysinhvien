using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysinhvien.Models
{
    internal class Teacher
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }

        public virtual DateTime Ngaysinh { get; set; }
        public virtual ICollection<Lophoc> Lophoc {  get; set; }
    }
}
