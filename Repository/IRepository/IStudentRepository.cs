using Quanlysinhvien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysinhvien.Repository.IRepository
{
    interface IStudentRepository
    {
        public List<sinhvien> GetSinhviens();
        public void Addnewstudent(sinhvien student);
        public void Updatenewstudent(sinhvien studentUpdate);
        public void Deletestudent(sinhvien student);
        public List<sinhvien> Sortbyname();
        public void Findstudentbyname();

    }
}
