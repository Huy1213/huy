using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001215808_DoThanhHuy_Buoi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = ASCIIEncoding.UTF8;
            Console.OutputEncoding = ASCIIEncoding.UTF8;
            int luaChon;
            do
            {
                menuHome();
                Console.Write("\nNhập lựa chọn:");
                luaChon = int.Parse(Console.ReadLine());
                switch (luaChon)
                {
                    case 1:
                        {

                            int luaChon1;
                            do
                            {
                                menu_BaiMau();
                                Console.Write("\nNhập lựa chọn bài mẫu:");
                                luaChon1 = int.Parse(Console.ReadLine());
                                BaiMau baimau = new BaiMau();
                                switch (luaChon1)
                                {
                                    case 1:
                                        {

                                            int[] A;
                                            Console.Write("Mời bạn nhập vào số phần tử: ");
                                            int n = int.Parse(Console.ReadLine());
                                            A = new int[n];
                                            A = baimau.NhapMang(A, n);
                                            Console.WriteLine("Mảng 1 chiều:");
                                            baimau.XuatMang(A);
                                            Console.WriteLine("\nSắp xếp trong mảng 1 chiều:");
                                            baimau.SapXep(A);
                                            baimau.XuatMang(A);
                                        }
                                        break;
                                    case 2:
                                        {
                                            int n, m;
                                            int[][] A;
                                            Console.Write("Mời bạn nhập số dòng: ");
                                            n = int.Parse(Console.ReadLine());
                                            Console.Write("Mời bạn nhập số cột: ");
                                            m = int.Parse(Console.ReadLine());
                                            // Khởi tạo
                                            A = new int[n][];
                                            for (int i = 0; i < n; i++)
                                            {
                                                A[i] = new int[m];
                                            }
                                            baimau.NhapMang2Chieu(A, n, m);
                                            baimau.XuatMang2Chieu(A);
                                        }
                                        break;
                                    case 3:
                                        {
                                            string S;
                                            Console.Write("Nhập chuỗi:");
                                            S = Console.ReadLine();
                                            char[] mangChuoi = S.ToCharArray();
                                            if (baimau.ChuoiDoiXung(mangChuoi))
                                            {
                                                Console.Write("Chuỗi đối xứng");
                                            }
                                            else
                                            {
                                                Console.Write("Chuỗi không đối xứng");
                                            }
                                        }
                                        break;
                                    default:
                                        break;
                                }
                            } while (luaChon1 != 0);
                        }
                        break;
                    case 2:
                        {

                            int luaChon1;
                            do
                            {
                                menu_BaiOLop();
                                Console.Write("\nNhập lựa chọn bài ở lớp:");
                                luaChon1 = int.Parse(Console.ReadLine());
                                BaiTapOLop bol = new BaiTapOLop();
                                switch (luaChon1)
                                {
                                    case 1:
                                        {
                                            Console.Write("\n\n------------MẢNG 1 CHIỀU-------------\n");
                                            int[] A;
                                            Console.Write("Nhập độ dài mảng:");
                                            int n = int.Parse(Console.ReadLine());
                                            A = new int[n];

                                            //Nhập xuất mảng 1 chiều
                                            bol.NhapMang1C(A,n);
                                            bol.XuatMang1C(A);

                                            //Liệt kê các phần tử lẻ ở vị trị chẵn.
                                            Console.Write("\n\n-------------------------------------");
                                            Console.WriteLine("\nCác phần tử lẻ ở vị trị chẵn:");
                                            bol.CacPhanTuLeVTChan(A);

                                            //Liệt kê các số nguyên tố trong mảng.
                                            Console.Write("\n\n-------------------------------------");
                                            Console.WriteLine("\nLiệt kê các số nguyên tố trong mảng:");
                                            bol.LietKeSNT(A);

                                            //Tìm phần tử âm đầu tiên trong mảng.
                                            Console.Write("\n\n-------------------------------------");
                                            Console.WriteLine("\nPhần tử đầu tiên trong mảng:");
                                            int ptdau = bol.PhanTuAmDauTien(A);
                                            if(bol.PhanTuAmDauTien(A)==0)
                                            {
                                                Console.WriteLine("Không có phần tử âm trong mảng");
                                            }    
                                            else
                                            {
                                                Console.WriteLine("Phần tử âm đầu tiên là: {0}", bol.PhanTuAmDauTien(A));
                                            }

                                            //Tìm max, min của dãy.     
                                            int max = bol.TimMax(A);
                                            int min = bol.TimMin(A);
                                            Console.Write("\n\n-------------------------------------");
                                            Console.WriteLine("\nTìm max, min của dãy:");
                                            Console.WriteLine("Max của dãy là: {0}", max);
                                            Console.WriteLine("Min của dãy là: {0}", min);

                                            //Tính tổng các phần tử trong mảng.
                                            int tong = bol.TongMang(A);
                                            Console.Write("\n-------------------------------------");
                                            Console.Write("\nTính tổng các phần tử trong mảng là: {0}", tong);
                                        }
                                        break;
                                    case 2:
                                        {                                    
                                            Console.Write("\n\n------------MẢNG 2 CHIỀU-------------\n");

                                            //Nhập xuất mảng 2 chiều
                                            int m, n;
                                            int[][] A;
                                            Console.Write("Nhập số dòng:");
                                            m = int.Parse(Console.ReadLine());
                                            Console.Write("Nhập số cột:");
                                            n= int.Parse(Console.ReadLine());       
                                            A= new int[m][];
                                            for (int i = 0; i < m; i++)
                                            {
                                                A[i] = new int[n];
                                            }
                                            bol.NhapMang2C(A, m, n);
                                            bol.XuatMang2C(A);

                                            //Tổng tất cả các phần tử dương của ma trận.
                                            Console.Write("\n\n-------------------------------------");
                                            Console.WriteLine("\nTổng tất cả các phần tử dương của ma trận:{0}", bol.TongPTuDuong(A));

                                            //Tổng các phần tử trên đường chéo chính.
                                            Console.Write("\n\n-------------------------------------");
                                            Console.WriteLine("\nTổng các phần tử trên đường chéo chính:{0}", bol.TongPTuTrenDCC(A));

                                            //Tổng các phần tử trong tam giác trên.
                                            Console.Write("\n\n-------------------------------------");
                                            Console.WriteLine("\nTổng các phần tử trong tam giác trên:{0}", bol.TongPTuTamGiacTren(A));

                                            //Tổng tất cả các phần tử chẵn của ma trận.
                                            Console.Write("\n\n-------------------------------------");
                                            Console.WriteLine("\nTổng các phần tử chẵn trong ma trận:{0}", bol.TongPTuChan(A));

                                            //Tính tổng các phần tử ở dòng thứ i.
                                            Console.Write("\n\n-------------------------------------");
                                            int x;
                                            Console.Write("\nNhập dòng cần tính tổng:");
                                            x = int.Parse(Console.ReadLine());
                                            Console.WriteLine("\nTổng các phần tử ở dòng thứ {0} là:{1}",x, bol.TongPTuDongThuI(A,x));
                                        }
                                        break;
                                    case 3:
                                        {
                                            Console.Write("\n\n----------------CHUỖI----------------\n");
                                            string S;
                                            Console.Write("\nNhập chuỗi:");
                                            S = Console.ReadLine();
                                            //Kiểm tra chuỗi đối xứng
                                            Console.Write("\n\n-------------------------------------");
                                            Console.WriteLine("\nS có phải là chuỗi đối xứng không?");
                                            char[] mangChuoi = S.ToCharArray();
                                            if (bol.ChuoiDoiXung(mangChuoi))
                                            {
                                                Console.Write("Chuỗi đối xứng");
                                            }
                                            else
                                            {
                                                Console.Write("Chuỗi không đối xứng");
                                            }
                                            
                                            //Đổi ký tự đầu từ thành chữ hoa
                                            Console.Write("\n\n-------------------------------------");
                                            Console.WriteLine("\nĐổi ký tự đầu từ thành chữ hoa:");
                                            Console.WriteLine("\n {0}", bol.ChuyenChuDauThanhHoa(S));

                                            //Đổi ký tự thường thành chuỗi hoa và ngược lại
                                            Console.Write("\n\n-------------------------------------");
                                            Console.WriteLine("\nĐổi ký tự thường thành chuỗi hoa và ngược lại:");
                                            Console.WriteLine("\nĐổi ký tự thường thành chuỗi hoa:");                                          
                                            string X = S.ToUpper();
                                            Console.WriteLine("{0}",X);
                                            Console.WriteLine("\nĐổi ký tự hoa thành chuỗi thường:");
                                            string X1 = S.ToLower();
                                            Console.WriteLine("{0}", X1);

                                            //Có bao nhiêu nguyên âm, phụ âm, khoảng trắng trong chuỗi s.
                                            Console.Write("\n\n-------------------------------------");
                                            Console.WriteLine("\nCó bao nhiêu nguyên âm, phụ âm, khoảng trắng trong chuỗi s:");
                                            bol.DemNguyenAmPhuAm(S);
                                        }
                                        break;                          
                                    default:
                                        break;
                                }
                            } while (luaChon1 != 0);
                        }
                        break;
                    default:
                        break;
                }
            } while (luaChon != 0);

            Console.ReadKey();
        }
        static void menuHome()
        {
            Console.WriteLine("\n---------------------MENU------------------------");
            Console.WriteLine("0.ĐỂ HỦY THAO TÁC");
            Console.WriteLine("1.BÀI MẪU");
            Console.WriteLine("2.BÀI Ở LỚP");
            Console.WriteLine("---------------------END-------------------------\n");
        }
        static void menu_BaiMau()
        {
            Console.WriteLine("\n--------------------------------------BÀI MẪU-----------------------------------------");
            Console.WriteLine("0.ĐỂ HỦY THAO TÁC");
            Console.WriteLine("1.Viết phương thức nhập mảng a gồm n phần tử, xuất mảng a.");
            Console.WriteLine("2.Viết phương thức nhập mảng 2 chiều a gồm n phần tử, xuất mảng 2 chiều.");
            Console.WriteLine("3.Nhập chuỗi S. Kiểm tra S có là chuỗi đối xứng không ?");
            Console.WriteLine("----------------------------------------END-------------------------------------------\n");
        }
        static void menu_BaiOLop()
        {
            Console.WriteLine("\n--------------------------------------BÀI Ở LỚP---------------------------------------");
            Console.WriteLine("0.ĐỂ HỦY THAO TÁC");
            Console.WriteLine("1.Mảng một chiều");
            Console.WriteLine("2.Mảng hai chiều");
            Console.WriteLine("3.Nhập chuỗi s (là họ tên).");        
            Console.WriteLine("-----------------------------------------END--------------------------------------------\n");
        }
    }
}
