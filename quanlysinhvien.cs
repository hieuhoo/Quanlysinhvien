using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysinhvien
{

     class quanlysinhvien
    {
        private List<SinhVien> ListSinhVien =  null;
        public quanlysinhvien()
        {
            ListSinhVien = new List<SinhVien>();
        }
        //id
        private int GenerateID()
        {
            int max = 1;
            if (ListSinhVien != null && ListSinhVien.Count > 0)
            {
                max = ListSinhVien[0].ID;
                foreach (SinhVien sv in ListSinhVien)
                {
                    if (max < sv.ID)
                    {
                        max = sv.ID;
                    }
                }
                max++;
            }
            return max;
        }
        public int SoLuongSinhVien()
        {
            int Count = 0;
            if (ListSinhVien != null)
            {
                Count = ListSinhVien.Count;
            }
            return Count;
        }
        public void NhapSinhVien()
        {
            // Theem một sinh viên mới
            SinhVien sv = new SinhVien();
            sv.ID = GenerateID();

            Console.Write("Nhap ten sinh vien: ");
            sv.Name = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap dia chi  sinh vien: ");
            sv.Diachi = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap lop hoc  sinh vien: ");
            sv.Lophoc = Convert.ToString(Console.ReadLine());




            ListSinhVien.Add(sv);
        }
        // chinh sua thong tin svien
        public void UpdateSinhVien(int ID)
        {
            // Tìm kiếm sinh viên trong danh sách ListSinhVien
            SinhVien sv = FindByID(ID);
            // Nếu sinh viên tồn tại thì cập nhập thông tin sinh viên
            if (sv != null)
            {
                Console.Write("Nhap ten sinh vien: ");
                string name = Convert.ToString(Console.ReadLine());
                // Nếu không nhập gì thì không cập nhật tên
                if (name != null && name.Length > 0)
                {
                    sv.Name = name;
                }
                Console.Write("Nhap dia chi sinh vien");
                string diachi = Convert.ToString(Console.ReadLine()) ;
                if (diachi != null && diachi.Length > 0)
                {
                    sv.Diachi = diachi ;
                }
                Console.Write("Nhaplop  sinh vien");
                string lophoc = Convert.ToString(Console.ReadLine());
                if (lophoc != null && lophoc.Length > 0)
                {
                    sv.Lophoc = lophoc;
                }

            }
        

        }
        //sap xep theo ten
        public void SortByName()
        {
            ListSinhVien.Sort(delegate (SinhVien sv1, SinhVien sv2) {
                return sv1.Name.CompareTo(sv2.Name);
            });
        }
        private SinhVien FindByID(int ID)
        {
            SinhVien searchResult = null;
            if (ListSinhVien != null && ListSinhVien.Count > 0)
            {
                foreach (SinhVien sv in ListSinhVien)
                {
                    if (sv.ID == ID)
                    {
                        searchResult = sv;
                    }
                }
            }
            return searchResult;
        }
        //xoa svien khoi danh sach 
        public bool DeleteById(int ID)
        {
            bool IsDeleted = false;
            // tìm kiếm sinh viên theo ID
            SinhVien sv = FindByID(ID);
            if (sv != null)
            {
                IsDeleted = ListSinhVien.Remove(sv);
            }
            return IsDeleted;
        }
        public List<SinhVien> FindByName(String keyword)
        {
            List<SinhVien> searchResult = new List<SinhVien>();
            if (ListSinhVien != null && ListSinhVien.Count > 0)
            {
                foreach (SinhVien sv in ListSinhVien)
                {
                    if (sv.Name.ToUpper().Contains(keyword.ToUpper()))
                    {
                        searchResult.Add(sv);
                    }
                }
            }
            return searchResult;
        }
        public void ShowSinhVien(List<SinhVien> listSV)
        {
            // hien thi tieu de cot
            Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} ",
                  "ID", "Name", "Diachi", "Lophoc");
            // hien thi danh sach sinh vien
            if (listSV != null && listSV.Count > 0)
            {
                foreach (SinhVien sv in listSV)
                {
                    Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5}",
                                      sv.ID, sv.Name, sv.Diachi, sv.Lophoc);
                }
            }
            Console.WriteLine();
        }

       
        /*d
   * Hàm trả về danh sách sinh viên hiện tại
   */
        public List<SinhVien> getListSinhVien()
        {
            return ListSinhVien;
        }
    }  
}
