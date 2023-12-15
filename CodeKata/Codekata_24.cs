using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//콜라츠 추측

namespace CodeKata
{
    public class Solution_24
    {
        public string solution(string[] seoul)
        {
            string answer = "";

            for(int i =0;  i < seoul.Length; i++)
            {
                if (seoul[i] =="Kim")
                {
                    answer = "김서방은" + i + "에 있다";
                    break;
                }
            }
            return answer;
        }
    }
}
