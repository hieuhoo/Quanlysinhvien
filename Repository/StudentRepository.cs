using NHibernate;
using NHibernate.Linq;
using Quanlysinhvien;
using Quanlysinhvien.Models;
using Quanlysinhvien.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysinhvien
{
    class StudentRepository : IStudentRepository
    {
        private readonly IClassRepository _classRepository;
        private readonly ISessionFactory _session;
        public StudentRepository(IClassRepository classRepository, ISessionFactory session)
        {
            _classRepository = classRepository;
            _session = session;
        }

        public void Addnewstudent(sinhvien student)
        {
            throw new NotImplementedException();
        }

        public void Deletestudent(sinhvien student)
        {
            throw new NotImplementedException();
        }

        public void Findstudentbyname()
        {
            throw new NotImplementedException();
        }

        public List<sinhvien> GetSinhviens()
        {
            throw new NotImplementedException();
        }

        public List<sinhvien> Sortbyname()
        {
            throw new NotImplementedException();
        }

        public void Updatenewstudent(sinhvien studentUpdate)
        {
            throw new NotImplementedException();
        }
    }

    
}
