using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//각도기
namespace CodeKata
{
    public class Solution_8
    {
        //public int solution(int angle)
        //{
        //    int anwser = 0;

        //    return anwser < 90 ? 1: angle == 90 ? 2 : angle < 180 ? 3 : 4 ;
        //}
        public int solution(int angle)
        {
            int answer = 0;
            if (angle > 0 && angle < 90)
            {
                answer = 1;
            }
            else if (angle == 90)
            {
                answer = 2;
            }
            else if (angle < 180)
            {
                answer = 3;
            }
            else if (angle == 180)
            {
                answer = 4;
            }
            return answer;
        }
    }
}
