using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//하샤드 수

namespace CodeKata
{
    public class Solution_21
    {
        public bool solution(int x)
        {
            bool answer;
            string temp = x.ToString();
            int sum = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                sum += (int)Char.GetNumericValue(temp[i]);
            }
            answer = (x % sum == 0) ? true : false;
            return answer;
        }
    }
}
