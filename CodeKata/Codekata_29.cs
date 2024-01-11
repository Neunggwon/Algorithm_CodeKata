using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//제일 작은 수 제거하기

namespace CodeKata
{
    public class Solution_29
    {
        public int[] solution(int[] arr)
        {
            List<int> answer = new List<int>(arr);
            int min = arr.Min();
            answer.RemoveAll(num => num == min);

            if (answer.Count == 0)
            {
                answer.Add(-1);
            }
            return answer.ToArray();
        }
    }
}
