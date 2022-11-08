using System;
using static System.Math;
using System.Collections.Generic;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        List<int> strs = new List<int>();
        
        while(true) {
            int value = n % 3;
            n = n / 3;
            strs.Add(value);
            if(n == 0) {
                break;
            }
        }
        strs.Reverse();
        
        for(int i = 0; i < strs.Count; i++) {
            int pow = (int)Math.Pow(3, i);
            int num = strs[i];
            answer += num * pow;
        }
        
        return answer;
    }
}