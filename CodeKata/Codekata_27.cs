using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//음양 더하기

namespace CodeKata
{
    public class Solution_27
    {
        public string solution(string phone_number)
        {
            string answer = "";
            for (int i = 0; i < phone_number.Length; i++)
            {
                if (i < phone_number.Length - 4)
                {
                    answer += "*";
                }
                else
                {
                    answer += phone_number[i];
                }
            }
            return answer;
        }
    }
}
