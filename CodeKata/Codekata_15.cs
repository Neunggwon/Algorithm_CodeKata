using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//나머지가 1이 되는 수 찾기
namespace CodeKata
{
    public class Solution_15
    {
        public int solution(int n)
        {
            int answer = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 1)
                {
                    answer = i;
                    break;
                }
            }
            return answer;
        }
    }
}
