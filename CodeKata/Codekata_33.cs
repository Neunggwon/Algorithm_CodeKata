using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//약수의 개수와 덧셈

namespace CodeKata
{
    public class Solution_33
    {
        public int solution(int left, int right)
        {
            int answer = 0;
            for (int i = left; i <= right; i++)
            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                answer = (count % 2 == 0) ? answer += i : answer -= i;
            }
            return answer;
        }
    }
}
