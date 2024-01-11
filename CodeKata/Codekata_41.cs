using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//이상한 문자 만들기

namespace CodeKata
{
    public class Solution
    {
        public string solution(string s)
        {
            string answer = "";
            char[] chars = s.ToCharArray();
            int index = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == ' ')
                {
                    answer += chars[i];
                    continue;
                }

                answer += (i % 2 == 0) ? chars[i].ToString().ToUpper() : chars[i].ToString().ToLower();
                //if (i % 2 == 0)
                //{
                //    answer += chars[i].ToString().ToUpper();
                //}
                //else
                //{
                //    answer += chars[i].ToString().ToLower();
                //}
                index++;
            }

            return answer;
        }
    }
}
