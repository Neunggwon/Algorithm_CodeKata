using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//두 수의 나눗셈
namespace CodeKata
{
    public class Solution_7
    {
        public int solution(int num1, int num2)
        {
            double answer = ((double)num1 / (double)num2) * 1000;
            return (int)answer;
        }
    }
}
