using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//수박수박수박수박수박수?

namespace CodeKata
{
    public class Solution_31
    {
        public string solution(int n)
        {
            string answer = "";
            //int temp = n - (n - 1);
            for (int i = 0; i < n; i++)
            {
                //if (temp % 2 == 0)
                //{
                //    answer += "박";
                //    temp++;
                //}
                //else
                //{
                //    answer += "수";
                //    temp++;
                //}
                answer += i % 2 == 0 ? "수" : "박";
            }
            return answer;
        }
    }
}
