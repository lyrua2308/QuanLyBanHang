using System;

namespace BaiTap6_21a4040067
{
    class Program
    {
        static void Main(string[] args)
        {
            //    SinhVien SV;
            //    SV = new SinhVien();
            //    SV.nhap();
            //    SV.DiemTB();
            //    SV.xuat();
            //    Console.ReadLine();

            //    SinhVien SV2;
            //    SV2 = new SinhVien("21a4040067", "nguyen thi ly", 2000, 5.5, 8.9);

            DanhSachSinhVien DS;
            DS = new DanhSachSinhVien();
            DS.NhapDS();
            DS.XuatDS();
            Console.WriteLine("sinh vien co diem tren 8.5");
            DS.DSSV();
            DS.sapxep();
            Console.Read(); ;


        }
    }
}
