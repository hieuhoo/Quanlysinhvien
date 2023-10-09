﻿
using FluentNHibernate.Mapping;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using Quanlysinhvien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysinhvien.Models.Mapping
{
     class LophocMapping : ClassMapping<Lophoc>
    {
        public LophocMapping() 
        {
            Table("lophoc");
            Id(x => x.Id ,m => m.Column("Id"));
            Property(x => x.Name);
            Property(x => x.SubjectName);
            ManyToOne(x => x.Teacher, m => m.Column("Idgv"));
            Bag(x => x.Sinhviens , c =>
            {
                c.Key(k => k.Column("Class"));
                c.Cascade(Cascade.All | Cascade.DeleteOrphans);
            } ,r => r.OneToMany()
            );

        }
    }
}
