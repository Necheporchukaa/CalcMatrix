using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcMatrix;

namespace Main
{
  class Program
  {
    static void Main(string[] args)
    {
      MyMatrix a = new MyMatrix();
      a.a = new int[3, 3]  { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };

      MyMatrix b = new MyMatrix();
      b.a = new int[3, 3]  { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

      MyMatrix plus = a + b;
      MyMatrix mult = a * b;
      MyMatrix minus = a - b;
      MyMatrix transp = minus.Transp();
    }
  }
}
