using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//숫자 비교하기
namespace CodeKata
{
    public class Solution_5
    {
        public int solution(int num1, int num2)
        {
            //int answer = num1 == num2 ? 1 : -1;
            int answer = 0;
            if (num1 ==  num2)
            {
                answer = 1;
            }
            else
            {
                answer = -1;
            }
            return answer;
        }
    }
}
