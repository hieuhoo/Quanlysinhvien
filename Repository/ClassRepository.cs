using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Linq;
using Quanlysinhvien.Models;
using Quanlysinhvien.Repository.IRepository;

namespace Quanlysinhvien.Repository
{
    internal class ClassRepository : IClassRepository
    {
        private readonly ISessionFactory session;
        public ClassRepository(ISessionFactory session)
        {
            this.session = session;
        }

        public List<Lophoc> GetAllClass()
        {
            using(var session = this.session.OpenSession())
            {
                return session.Query<Lophoc>()
                    .Fetch(s => s.Teacher)
                    .ToList();
            }
            throw new NotImplementedException();
        }
    }
}
