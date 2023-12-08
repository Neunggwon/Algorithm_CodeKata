using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//정수 제곱근 판별
namespace CodeKata
{
    public class Solution_19
    {
        public long solution(long n)
        {
            long answer = 0;
            double x = Math.Sqrt(n);
            if (x % 1 == 0)
            {
                answer = (long)(x + 1 * x + 1);
            }
            else
            {
                answer = -1;
            }
            return answer;
        }
    }
}
