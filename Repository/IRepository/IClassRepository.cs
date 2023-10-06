using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlysinhvien;
using Quanlysinhvien.Models;

namespace Quanlysinhvien.Repository.IRepository
{
    interface IClassRepository
    {
        public List<Lophoc> GetAllClass();
    }
}
