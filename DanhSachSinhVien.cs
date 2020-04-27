using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap6_21a4040067
{
    class DanhSachSinhVien
    {
        private int n;
        private SinhVien[] DS;
        private int i;
        private int j;
        public void NhapDS()
        {
            Console.WriteLine("-------NHAP DANH SACH SINH VIEN-----");
            Console.WriteLine("nhap vao so luong mang");
            n = Int32.Parse(Console.ReadLine());
            DS = new SinhVien[n];
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("nhap vao sinh vien thu {0}", i);
                DS[i] = new SinhVien();
                DS[i].nhap();

            }
        }
        public void XuatDS()
        {
            if (DS != null && n > 0) ;
            Console.WriteLine("---------DANH SACH SINH VIEN LA----------");
            for (i = 0; i < n; i++)
            {
                DS[i].DiemTB();
                DS[i].xuat();
            }

        }
       

        public void DSSV()
        {
            Console.WriteLine("--------SINH VIEN DIEM TREN 8.5--------");
            for (i = 0; i < n; i++)
            {
                if (DS[i].CheckDiem())
                {
                    DS[i].xuat();
                }

            }


        }
        public void sapxep()
        {
            for (int i = 0; i < n-1; i++)
                for (int j = 0; j < n; j++)    
                {
                    if (string.Compare(DS[i].masv, DS[j].masv, true)>0)
                    {
                        SinhVien tg = new SinhVien();
                        tg = DS[i];
                        DS[i] = DS[j];
                        DS[j] = tg;
                    }
                }
            Console.WriteLine("-----------SAP XEP TANG DAN LA----------");
            for(i=0;i<n;i++)
            {
                DS[i].xuat();
            }    
         }
    }
}

