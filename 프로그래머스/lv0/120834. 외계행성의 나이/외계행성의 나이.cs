using System;
using System.Collections.Generic;
public class Solution {
    public string solution(int age) {
        string answer = "";
        string[] alpha = new string[] {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "n", "m", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
        string arr = age.ToString();
        for(int i = 0; i < arr.Length; i ++) {
            int index = (int)Char.GetNumericValue(arr[i]);
            answer += alpha[index];
        }
        
        return answer;
    }
}