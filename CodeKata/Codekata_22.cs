using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//하샤드 수

namespace CodeKata
{
    public class Solution_22
    {
        public long solution(int a, int b)
        {
            long answer = 0;
            if ( a > b)
            {
                for (int i = a; i < b; i++)
                {
                    answer += i;
                }
            }
            else
            {
                for (int i = a; i >= b; i--)
                {
                    answer += i;
                }
            }
            return answer;
        }
    }
}
