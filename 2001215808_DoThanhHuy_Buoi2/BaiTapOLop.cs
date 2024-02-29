using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001215808_DoThanhHuy_Buoi2
{
    internal class BaiTapOLop
    {
        //Mảng 1 chiều

        //Nhập mảng 1 chiều
        public void NhapMang1C(int[] A, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Mời nhập phần tử A[{0}]=", i);
                A[i] = int.Parse(Console.ReadLine());
            }
        }
        public void XuatMang1C(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("{0}\t", A[i]);
            }
        }

        //Liệt kê các phần tử lẻ ở vị trị chẵn.
        public void CacPhanTuLeVTChan(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 != 0 && i % 2 == 0)
                {
                    Console.Write("{0}\t", A[i]);
                }
            }
        }

        //KT số nguyên tố
        public bool KTSNT(int n)
        {
            if (n < 2)
                return false;
            else
            {
                for (int i = 2; i <= Math.Sqrt((float)n); i++)
                {
                    if (n % i == 0)
                        return false;
                }
                return true;
            }
        }
        public void LietKeSNT(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (KTSNT(A[i]))
                    Console.Write("{0}\t", A[i]);
            }
        }

        //Tìm phần tử âm đầu tiên trong mảng.
        public int PhanTuAmDauTien(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < 0)
                    return A[i];
            }
            return 0;
        }

        //Tìm max, min của dãy.
        public int TimMax(int[] A)
        {
            int max = A[0];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > max)
                    max = A[i];
            }
            return max;
        }
        public int TimMin(int[] A)
        {
            int min = A[0];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < min)
                    min = A[i];
            }
            return min;
        }

        //Tính tổng các phần tử trong mảng.
        public int TongMang(int[] A)
        {
            int tong = 0;
            for (int i = 0; i < A.Length; i++)
            {
                tong += A[i];
            }
            return tong;
        }

        //Mảng 2 chiều

        //Nhập mảng 2 chiều
        public void NhapMang2C(int[][] A, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Nhập phần tử A[{0}][{1}]=", i, j);
                    A[i][j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void XuatMang2C(int[][] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    Console.Write("{0} ", A[i][j]);
                }
                Console.WriteLine();
            }
        }

        //Tổng tất cả các phần tử dương của ma trận.
        public int TongPTuDuong(int[][] A)
        {
            int tong = 0;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    if (A[i][j] > 0)
                        tong += A[i][j];
                }
            }
            return tong;
        }

        //Tổng các phần tử trên đường chéo chính.
        public int TongPTuTrenDCC(int[][] A)
        {
            int tong = 0;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    if (i == j)
                        tong += A[i][j];
                }
            }
            return tong;
        }

        //Tổng các phần tử trong tam giác trên.
        public int TongPTuTamGiacTren(int[][] A)
        {
            int tong = 0;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    if (i < j)
                        tong += A[i][j];
                }
            }
            return tong;
        }

        //Tổng tất cả các phần tử chẵn của ma trận.
        public int TongPTuChan(int[][] A)
        {
            int tong = 0;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    if (A[i][j] % 2 == 0)
                        tong += A[i][j];
                }
            }
            return tong;
        }

        //Tính tổng các phần tử ở dòng thứ i.
        public int TongPTuDongThuI(int[][] A, int m)
        {
            int tong = 0;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    if (j == m)
                        tong += A[m][i];
                }
            }
            return tong;
        }

        //Chuỗi S 


        //S có phải là chuỗi đối xứng không?
        public bool ChuoiDoiXung(char[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != A[A.Length - 1 - i])
                    return false;
            }
            return true;
        }
        public string ChuyenChuDauThanhHoa(string S)
        {
            S = S.ToLower();
            char[] array = S.ToCharArray();
            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }
        public void DemNguyenAmPhuAm(string S)
        {
            int i, len, nguyenAm, phuAm;
            nguyenAm = 0;
            phuAm = 0;
            len = S.Length;

            for (i = 0; i < len; i++)
            {

                if (S[i] == 'a' || S[i] == 'e' || S[i] == 'i' || S[i] == 'o' ||
                    S[i] == 'u' || S[i] == 'A' || S[i] == 'E' || S[i] == 'I' ||
                    S[i] == 'O' || S[i] == 'U')
                {
                    nguyenAm++;
                }
                else if ((S[i] >= 'a' && S[i] <= 'z') || (S[i] >= 'A' && S[i] <= 'Z'))
                {
                    phuAm++;
                }
            }
            Console.Write("\nSố nguyên âm là: {0}\n", nguyenAm);
            Console.Write("Số phụ âm là: {0}\n\n", phuAm);
        }
    }
}
