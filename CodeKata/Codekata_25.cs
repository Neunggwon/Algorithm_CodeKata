using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//나누어 떨어지는 숫자 배열

namespace CodeKata
{
    public class Solution_25
    {
        public int[] solution(int[] arr, int divisor)
        {
            //int[] answer = new int[] { };
            List<int> answer = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % divisor == 0)
                {
                    //answer 에 추가
                    answer.Add(arr[i]);
                }
            }
            if (answer.Count == 0)
            {
                answer[0] = -1;
            }
            answer.Sort();
            return answer.ToArray();
        }
    }
}
