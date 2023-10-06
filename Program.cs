// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Data.SqlClient;
using Quanlysinhvien;
using NHibernate;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Mapping.ByCode;
using NHibernate.Cfg.MappingSchema;
using System.Reflection;
using Quanlysinhvien.Models;
using Quanlysinhvien.Mapping;
using FluentNHibernate.MappingModel.ClassBased;

using Configuration= NHibernate.Cfg.Configuration;
using System.Transactions;

namespace Quanlysinhvien
{
    class Program
    {
        static void Main(string[] args)
        {
           
           

            quanlysinhvien quanLySinhVien = new quanlysinhvien();

            while (true)
            {
                Console.WriteLine("\nCHUONG TRINH QUAN LY SINH VIEN C#");
                Console.WriteLine("*************************MENU**************************");
                Console.WriteLine("**  1. Add new student.                               **");
                Console.WriteLine("**  2. Update student information .          **");
                Console.WriteLine("**  3. Delete student .                         **");
                Console.WriteLine("**  4. Find student by name.                  **");

                Console.WriteLine("**  5. Sort student by name.                   **");

                Console.WriteLine("**  6. Show list student.                 **");
                Console.WriteLine("**  7 Exit                                         **");
                Console.WriteLine("*******************************************************");
                Console.Write("choose option: ");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("\n1. Addnewstudent.");
                        quanLySinhVien.NhapSinhVien();
                        Console.WriteLine("\nAdd new student successful!");
                        break;
                    case 2:
                        if (quanLySinhVien.SoLuongSinhVien() > 0)
                        {
                            int id;
                            Console.WriteLine("\n2. Updatestudentinformation. ");
                            Console.Write("\nwrite ID: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            quanLySinhVien.UpdateSinhVien(id);
                        }
                        else
                        {
                            Console.WriteLine("\nList is empty!");
                        }
                        break;
                    case 3:
                        if (quanLySinhVien.SoLuongSinhVien() > 0)
                        {
                            int id;
                            Console.WriteLine("\n3. Deletestudent.");
                            Console.Write("\nWrite ID: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            if (quanLySinhVien.DeleteById(id))
                            {
                                Console.WriteLine("\nStudent with id = {0} is deleted.", id);
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nList is empty!");
                        }
                        break;
                    case 4:
                        if (quanLySinhVien.SoLuongSinhVien() > 0)
                        {
                            Console.WriteLine("\n4. Findstudentbyname.");
                            Console.Write("\nWrite name to search: ");
                            string name = Convert.ToString(Console.ReadLine());
                            List<SinhVien> searchResult = quanLySinhVien.FindByName(name);
                            quanLySinhVien.ShowSinhVien(searchResult);
                        }
                        else
                        {
                            Console.WriteLine("\nList is empty!");
                        }
                        break;


                    case 5:
                        if (quanLySinhVien.SoLuongSinhVien() > 0)
                        {
                            Console.WriteLine("\n6. Sortbyname.");
                            quanLySinhVien.SortByName();
                            quanLySinhVien.ShowSinhVien(quanLySinhVien.getListSinhVien());
                        }
                        else
                        {
                            Console.WriteLine("\nList is empty!");
                        }
                        break;
                    case 6:
                        if (quanLySinhVien.SoLuongSinhVien() > 0)
                        {
                            Console.WriteLine("\n7. Showliststudent.");
                            quanLySinhVien.ShowSinhVien(quanLySinhVien.getListSinhVien());
                        }
                        else
                        {
                            Console.WriteLine("\nList is empty!");
                        }
                        break;






                    case 7:
                        Console.WriteLine("\nYOu choose exit!");
                        break;
                    default:
                        Console.WriteLine("\nThis function don't have!");
                        Console.WriteLine("\nCHoose option in  menu.");
                        break;
                }




            }
        }
    }
}

