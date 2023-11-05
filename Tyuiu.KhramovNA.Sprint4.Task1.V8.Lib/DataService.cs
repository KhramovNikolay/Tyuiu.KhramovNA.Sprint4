using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KhramovNA.Sprint4.Task1.V8.Lib
{
    public class DataService : ISprint4Task1V8
    {
        public int Calculate(int[] array)
        {
            int pro = 0;
            foreach (int i in array)
            {
                if (i % 2 == 0)
                {
                    pro += i;
                }
            }
            return pro;
        }
    }
}