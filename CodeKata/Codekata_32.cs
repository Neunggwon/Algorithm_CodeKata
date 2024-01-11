using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//내적

namespace CodeKata
{
    public class Solution_32
    {
        public int solution(int[] a, int[] b)
        {
            int answer = 0;
            for (int i = 0; i < a.Length; i ++)
            {
                answer += a[i] * b[i];
            }
            return answer;
        }
    }
}
