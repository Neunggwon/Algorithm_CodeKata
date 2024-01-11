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
    public class Solution_26
    {
        public int solution(int[] absolutes, bool[] signs)
        {
            int answer = 0;

            for (int i = 0; i < absolutes.Length; i++)
            {
                // answer에 absolutes원소들을 더해주는데 각 원소는
                // signs[i]의 참거짓에 따라서, 그냥 더해지거나 -1을 곱해서 음수로 더해짐
                answer += absolutes[i] = signs[i] ? absolutes[i] : absolutes[i] * -1;
            }

            return answer;
        }
    }
}
