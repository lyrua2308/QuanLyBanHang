using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap6_21a4040067
{
    class SinhVien
    {

        public string masv;
        public string hoten;
        public int namsinh;
        public double diemlaptrinh;
        public double diemCSDL;
        public double diemTB;

        public SinhVien()
        {
            masv = "";
            hoten = "";
            namsinh = 2000;
            diemlaptrinh = 0;
            diemCSDL = 0;
            diemTB = 0;
        }
         public void nhap()
        {
            Console.WriteLine(" nhap ma cua sinh vien: ");
            masv = Console.ReadLine();
            Console.WriteLine("nhap ho ten cua sinh vien ");
            hoten = Console.ReadLine();
            Console.WriteLine(" nhap nam sinh cua sinh vien ");
            namsinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap vao diem lap trinh ");
            diemlaptrinh = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nhap vao diem CSDL ");
            diemCSDL = Convert.ToDouble(Console.ReadLine());
        }
        public void DiemTB()
        {
            diemTB = (diemlaptrinh + diemCSDL) * 0.5;
        }
        public void xuat()
        {
            
            Console.WriteLine("{0} \t {1} \t {2}"+ "\n diem lap trinh la {3} \n diem CSDL la {4} \n diem trung binh la {5} ", masv, hoten, namsinh ,diemlaptrinh, diemCSDL, diemTB);
        }

        public SinhVien(string masv,string hoten , int namsinh, double diemlaptrinh, double diemCSDL )
        {
            this.masv = masv;
            this.hoten = hoten;
            this.namsinh = namsinh;
            this.diemlaptrinh = diemlaptrinh;
            this.diemCSDL = diemCSDL;

            diemTB = (diemlaptrinh + diemCSDL) * 0.5;

            Console.WriteLine("{0} \t {1} \t {2}" + "\n diem lap trinh la {3} \n diem CSDL la {4} \n diem trung binh la {5} ", masv, hoten, namsinh, diemlaptrinh, diemCSDL, diemTB);

        }
        public bool CheckDiem()
        {
            bool Diem = false;
            if (diemTB > 8.5) Diem = true;
            return Diem;


        }

    }
}
