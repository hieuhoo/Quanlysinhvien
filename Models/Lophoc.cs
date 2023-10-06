using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysinhvien.Models
{
    internal class Lophoc
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string SubjectName {  get; set; }
        public virtual Teacher Teacher { get; set; }

        public virtual ICollection<sinhvien> Sinhviens { get; set; }
        public override string ToString()
        {
            return $"{Id}-{Name}-{SubjectName}";
        }
    }
}
