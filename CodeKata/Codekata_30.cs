using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//가운데 글자 가져오기

namespace CodeKata
{
    public class Solution_30
    {
        public string solution(string s)
        {
            string answer = "";
            if (s.Length % 2 == 0)
            {
                answer += s[s.Length / 2 - 1];
                answer += s[s.Length / 2];
            }
            else
            {
                answer += s[s.Length / 2];
            }
            return answer;
        }
    }
}
