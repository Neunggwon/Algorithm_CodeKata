using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//짝수와 홀수
namespace CodeKata
{
    public class Solution_11
    {
        public class Solution {
            public string solution(int num)
            {
                string answer = "";

                if (num % 2 == 0)
                {
                    answer = "EVen";
                }
                else
                {
                    answer = "Odd";
                }
                return answer;
            }
        }
    }
}
