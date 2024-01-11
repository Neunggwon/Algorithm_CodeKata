using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//문자열 다루기 기본

namespace CodeKata
{
    public class Solution_36
    {
        public bool solution(string s)
        {
            bool answer = true;
            if (s.Length == 4 ||  s.Length == 6)
            {
                answer = int.TryParse(s, out int temp);
            }
            return answer;
        }
    }
}
