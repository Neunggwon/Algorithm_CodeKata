using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//자릿수 구하기
namespace CodeKata
{
    public class Solution_13
    {
        public int solution(int n)
        {
            int answer = 0;
            while (n != 0)
            {
                answer = n % 10;
                n = n / 10;
            }
            return answer;
        }
    }
}
