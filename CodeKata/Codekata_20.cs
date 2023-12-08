using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//정수 내림차순으로 배치하기

namespace CodeKata
{
    public class Solution_20
    {
        public long solution(long n)
        {
            long answer = 0;
            char[] chars = n.ToString().ToCharArray();
            Array.Sort(chars);
            Array.Reverse(chars);
            answer = Convert.ToInt64(new string(chars));
            return answer;
        }
    }
}
