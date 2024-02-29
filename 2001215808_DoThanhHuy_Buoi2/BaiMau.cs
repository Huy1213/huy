using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001215808_DoThanhHuy_Buoi2
{
    internal class BaiMau
    {


        //Bai 1
        public int[] NhapMang(int[] A, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Mời nhập phần tử A[{0}]=", i);
                A[i] = int.Parse(Console.ReadLine());
            }
            return A;
        }
        public void XuatMang(int[] A)
        {
            // Xử lý
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("\t {0}", A[i]);
            }
        }
        public void SapXep(int[] A)
        {
            // Sắp xếp tăng
            Array.Sort(A);
        }

        //Bai 2
        public void NhapMang2Chieu(int[][] A, int n, int m)
        {
            // Xử lý
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Nhập phần tử A[{0}][{1}]= ", i, j);
                    A[i][j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void XuatMang2Chieu(int[][] A)
        {
            // Xử lý
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    Console.Write("{0} ", A[i][j]);
                }
                Console.WriteLine();
            }
        }

        //Bai 3
        public bool ChuoiDoiXung(char[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != A[A.Length - 1 - i])
                    return false;
            }
            return true;
        }
        
    }
}
