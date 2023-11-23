using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//짝수의 합
namespace CodeKata
{
    public class Solution_9
    {
        public int solution(int n)
        {
            int answer = 0;
            for (int i = 0; i < n; i++)
            {
                if (n % 2 == 0)
                {
                    answer += i;
                }
            }
            return answer;
        }
    }
}
