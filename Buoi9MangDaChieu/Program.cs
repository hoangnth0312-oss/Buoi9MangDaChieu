// //Khai bao mang da chieu
//
// //2D
//
// using System.Diagnostics;
//
// int[] abc = {1,2,3,4,5};
//
// //Khai Bao mang 2 chieu
//
// int[,] matrix = new int[3,4];
// //in ra ma tran co 3 mang va 4 cot
//
// int[,] matrix3 =
// {
//     {2,3,1,2},
//     {4,5,6,7},
//     {8,9,10,11}
// };
// //duyet mang : doc cac thong tin, bien trong mang
// //gan gia tri
// matrix[0,0] = 10; //hang 0 cot 0
// matrix[0,1] = 11;//hang 0 cot 1
// matrix[0,2] = 12;//hang 0 cot 3
// matrix[0,3] = 13;//hang 0 cot 4
// //matrix[0,5] = 14;// hang 0 cot 5: loi do khong co cot 5
//
// //lay gia tri
// Console.WriteLine(matrix[0,1]);
// Console.WriteLine(matrix[0,2]);
// Console.WriteLine(matrix[0,3]);
//
// Console.WriteLine(matrix[1,2]);
//
//
// //so hang va cot
// Console.WriteLine("row" + matrix.GetLength(0) + " col" + matrix.GetLength(1));
//
// //duyet mang
// //in ra toan bo gia tri cua mang
// int row = matrix.GetLength(0);
// int col = matrix.GetLength(1);
// for (int i = 0; i < row; i++)
// {
//     for (int j = 0; j < col; j++)
//     {
//         Console.Write(matrix[i, j] + " ");
//     }
//     Console.WriteLine();
// }

//Nhap vao vi tri i,j : matrix[i,j] =int.Parse(Console.ReadLine());

int[,] matrix = new int[3,4];

int row = matrix.GetLength(0);
int col = matrix.GetLength(1);

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        Console.Write($"Nhap gia tri trong hang {i} va cot {j}");
        matrix[i, j] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine();
}
int sum =0;
foreach (int item in matrix)
{
    sum += item;
}
Console.WriteLine("Tong tat ca cac phan tu trong ma tran la: " + sum);

//chan le

int countChan = 0;
int countLe = 0;

foreach (int item in matrix)
{
    if (item % 2 == 0)
    {
        countChan++; // Tăng biến đếm chẵn
    }
    else
    {
        countLe++;   // Tăng biến đếm lẻ
    }
}

Console.WriteLine("So luong so chan: " + countChan);
Console.WriteLine("So luong so le: " + countLe);

//tim gia tri lon nhat va nho nhat
int min = matrix[0, 0];
int max = matrix[0, 0];

foreach (int item in matrix)
{
    if (item < min)
    {
        min = item; // Cập nhật kỷ lục nhỏ nhất mới
    }
    
    if (item > max)
    {
        max = item; // Cập nhật kỷ lục lớn nhất mới
    }
}

Console.WriteLine("Gia tri nho nhat (Min): " + min);
Console.WriteLine("Gia tri lon nhat (Max): " + max);