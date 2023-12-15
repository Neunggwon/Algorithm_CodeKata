using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//콜라츠 추측

namespace CodeKata
{
    public class Solution_23
    {
        public int solution(int num)
        {
            int answer = 0;
            for (int i = 0; i < 500; i++)
            {
                if (num % 2 == 0)
                {
                    num = num * 2;
                }
                else if (num % 2 != 0)
                {
                    num = num * 3 + 1;
                }
            }

            answer = (num == 1) ? 1 : -1;
            return answer;
        }
    }
}
