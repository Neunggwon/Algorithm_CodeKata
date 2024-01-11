using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//없는 숫자 더하기

namespace CodeKata
{
    public class Solution_28
    {
        public int solution(int[] numbers)
        {
            int answer = 45;
            for(int i = 0; i < numbers.Length; i++)
            {
                answer -= numbers[i];
            }
            return answer;
        }
    }
}
