using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using Quanlysinhvien.Models;

namespace Quanlysinhvien.Models.Mapping
{
    internal class TeacherMapping : ClassMapping<Teacher>
    {
        public TeacherMapping() 
        {
            Table("giaovien");
            Id(x => x.Id, map => map.Column("Idgv"));
            Property(x => x.Name);
            Property(x => x.Ngaysinh);
            Bag(x => x.Lophoc, c =>
            {
                c.Key(k => k.Column("Teacher"));
                c.Cascade(Cascade.All | Cascade.DeleteOrphans);
                c.Inverse(true);
            }, r => r.OneToMany());
        }
    }
}
