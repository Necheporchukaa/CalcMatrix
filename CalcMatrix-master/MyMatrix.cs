using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcMatrix
{
    public class MyMatrix
    {
      public int[,] a = new int[3, 3];

      //сложение
      public static MyMatrix operator +(MyMatrix matrix1, MyMatrix matrix2)
      {
          MyMatrix NewMatrix = new MyMatrix();
          for (int i = 0; i < 3; i++)
              for (int j = 0; j < 3; j++)
                  NewMatrix.a[i, j] = matrix1.a[i, j] + matrix2.a[i, j];

          return NewMatrix;
      }
      
      //вычитание
      public static MyMatrix operator -(MyMatrix matrix1, MyMatrix matrix2)
      {
          MyMatrix NewMatrix = new MyMatrix();
          for (int i = 0; i < 3; i++)
              for (int j = 0; j < 3; j++)
                  NewMatrix.a[i, j] = matrix1.a[i, j] - matrix2.a[i, j];

          return NewMatrix;
      }

      //умножение
      public static MyMatrix operator *(MyMatrix matrix1, MyMatrix matrix2)
      {
          MyMatrix NewMatrix = new MyMatrix();
          for (int i = 0; i < 3; i++)
              for (int k = 0; k < 3; k++)
                  for (int j = 0; j < 3; j++)
                      NewMatrix.a[i, k] += matrix1.a[j, k] * matrix2.a[i, j];

          return NewMatrix;
      }

      //транспонирование
      public MyMatrix Transp()
      {
          MyMatrix NewMatrix = new MyMatrix();
          for (int i = 0; i < 3; i++)
              for (int j = 0; j < 3; j++)
                  NewMatrix.a[i, j] = a[j, i];

          return NewMatrix;
      }

    }
}
