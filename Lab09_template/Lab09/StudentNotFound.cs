using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab09
{
    class StudentNotFound : Exception
    {
      public StudentNotFound(string name,int no)
      {
            Console.WriteLine($"{name} isimli, {no} numaralı öğrenci bulunamamıştır.");
      }

    }
}
