using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//x만큼 간격이 있는 n개의 숫자
namespace CodeKata
{
    public class Solution_16
    {
        public long[] solution(int x, int n)
        {
            long[] answer = new long[n];
            for (int i = 0; i < n; i++ )
            {
                answer[i] = x + (x * i);
            }
            return answer;
        }
    }
}
