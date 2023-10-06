using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using Quanlysinhvien.Models;

namespace Quanlysinhvien.Mapping
{
     class SInhvienMapping : ClassMapping<sinhvien>
    {
        public SInhvienMapping()
        {
            Table("sinhvien");
            Id(x => x.ID, map => map.Column("ID"));
            Property(x => x.Name);
            Property(x => x.Diachi);
            Property(x => x.Lophoc);
        }
    }
}
