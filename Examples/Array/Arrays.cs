using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Array
{
    public class OneDimensionArray
    {
        int[] a;    //Lúc này a vẫn null

        int[] b = new int[6]; //Khởi tạo mảng b trong bộ nhớ heap với độ dài 6 phần tử

        int[] c = new int[] { 1, 2, 3, 4 }; //Khởi tạo mảng c với 4 phần tử cho trước

        int[] d = { 1, 2, 3, 4, 5 }; //Khởi tạo mảng d với 5 phần tử cho trước

        int[] e = Enumerable.Repeat<int>(1, 1000).ToArray();    //Khởi tạo mảng e với 1000 phần tử có giá trị = 1
    }

    public class JaggedArray
    {
        //Khai báo
        //Lưu ý: chúng ta chỉ quy định được chiều dài của mảng chính chứ không 
        //       quy định được chiều dài các mảng con do chưa biết chiều dài
        //       chính xác của các mảng con
        int[][] a = new int[3][];

        //Tạo giá trị cho mảng a
        private void createArrayA()
        {
            for (int i = 0; i < 3; i++)
            {
                a[i] = new int[] { i * 3 + 1, i * 3 + 2, i * 3 + 3 };
            }

            /*Kết quả: a = [
             *              [1, 2, 3],
             *              [4, 5, 6],
             *              [7, 8, 9],
                           ];
            */
        }

        //Khai báo với các giá trị cho trước kiểu bá đạo
        //Yêu cầu: do khai báo mảng b là int[3][], chiều dài mảng trước đã được
        //         quy định là 3 nên trong mảng chính phải tạo đúng 3 mảng con
        int[][] b = new int[3][] { new int[] { 1, 2, 3 }, new int[] { 1, 2}, new int[] { 1, 2, 3, 4} };

        //Khai báo mảng mà không cần biết chiều dài của mảng chính
        int[][] c = {
            new int[] { 1, 2, 3},
            new int[] { 1, 2},
        };

        
    }

    public class TwoDimensionArray
    {
        int[,] a = new int[2, 3];

        private void createArrayA()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    a[i, j] = i * 3 + j + 1;
                }
            }

            /*Kết quả: a = [
                            1, 2, 3
                            4, 5, 6
                           ];
            */
        }

        int[,] b = { { 1, 2 }, { 1, 3 } };

        int[,] c = { new int[] { 1, 2 }, new int[] { 2, 3 } };
    }
}
