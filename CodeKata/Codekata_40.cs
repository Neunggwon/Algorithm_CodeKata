using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//3진법 뒤집기

namespace CodeKata
{
    public class Solution_40
    {
        public int solution(int n)
        {
            int answer = n;
            List<int> list = new List<int>();

            while(answer > 0)
            {
                list.Add(answer % 3);
                answer /= 3;
            }

            list.Reverse();

            for (int i = 0; i < list.Count; i++)
            {
                answer += (int)(list[i] * Math.Pow(3, i));
            }
            return answer;
        }
    }
}
