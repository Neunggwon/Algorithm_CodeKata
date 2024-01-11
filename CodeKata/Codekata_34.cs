using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//문자열 내림차순으로 배치하기

namespace CodeKata
{
    public class Solution_34
    {
        public string solution(string s)
        {
            string answer = "";
            answer = new string(s.OrderByDescending(x => x).ToArray());
            return answer;
        }
    }
}
