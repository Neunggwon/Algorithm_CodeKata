using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata
{
    //자릿수 구하기
    internal class Solution_3
    {
        public int solution(int n)
        {
            int answer = 0;
            string strN = n.ToString();
            for (int i = 0; i < strN.Length; i++)
            {
                answer += (int)Char.GetNumericValue(strN[i]);
            }
            return answer;
        }
    }
}
