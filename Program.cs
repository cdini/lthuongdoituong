using System;

class Program {
  struct SV
    {
      public string hoten;
      public string masv;
      public string diachi;
    }
  static void Main (string[] args) 
  {
    SV sinhvien01;
    sinhvien01.hoten = "Nguyen Van A";
    sinhvien01.masv = "20000769";
    sinhvien01.diachi = "C3/11M";
    Console.WriteLine("\nHo ten: "+sinhvien01.hoten+"\nMa sinh vien: "+sinhvien01.masv+"\nDia chi:"+sinhvien01.diachi);

    SV sinhvien02;
    sinhvien02.hoten = "Nguyen Van Teo";
    sinhvien02.masv = "20003369";
    sinhvien02.diachi = "C3/11M";
    Console.WriteLine("\nHo ten: "+sinhvien02.hoten+"\nMa sinh vien: "+sinhvien02.masv+"\nDia chi:"+sinhvien02.diachi);

    SV sinhvien03;
    sinhvien03.hoten = "Bui Tien Dung";
    sinhvien03.masv = "20000769";
    sinhvien03.diachi = "C3/11M";
    Console.WriteLine("\nHo ten: "+sinhvien03.hoten+"\nMa sinh vien: "+sinhvien03.masv+"\nDia chi:"+sinhvien03.diachi);

    SV sinhvien04;
    sinhvien04.hoten = "Nguyen Tuan Anh";
    sinhvien04.masv = "20000469";
    sinhvien04.diachi = "C5/11M";
    Console.WriteLine("\nHo ten: "+sinhvien04.hoten+"\nMa sinh vien: "+sinhvien04.masv+"\nDia chi:"+sinhvien04.diachi);

    SV sinhvien05;
    sinhvien05.hoten = "Nguyen Van Quyet";
    sinhvien05.masv = "20000169";
    sinhvien05.diachi = "127/85";
    Console.WriteLine("\nHo ten: "+sinhvien05.hoten+"\nMa sinh vien: "+sinhvien05.masv+"\nDia chi:"+sinhvien05.diachi);

    Console.ReadLine();

  }
} 