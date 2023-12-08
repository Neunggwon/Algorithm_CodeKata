using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//x만큼 간격이 있는 n개의 숫자
namespace CodeKata
{
    public class Solution_17    
    {
        public int[] solution(long n)
        {
            string str = n.ToString();
            int[] answer = new int[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                answer[i] = int.Parse(str[i].ToString());
            }

            Array.Reverse(answer);
            return answer;
        }
    }
}
