using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KhramovNA.Sprint4.Task0.V25.Lib
{
    public class DataService : ISprint4Task0V25
    {
        public int GetSumEvenArrEl(int[] array)
        {
            int res = 0;
            foreach (int numbers in array)
            {
                if (numbers % 2 == 0)
                {
                    res += numbers;
                }
            }
            return res;
        }
    }
}