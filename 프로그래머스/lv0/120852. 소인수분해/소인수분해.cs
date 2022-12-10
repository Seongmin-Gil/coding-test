using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int n) {
        List<int> list = new List<int>();
        int divider = 2;
        while(n >= 2)
        {
            if(n % divider == 0)
            {
                list.Add(divider);
                n /= divider;
            } else {
                divider ++;
            }
        }
            
        return list.Distinct().ToArray();
    }
}