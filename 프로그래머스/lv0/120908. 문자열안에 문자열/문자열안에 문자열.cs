using System;

public class Solution {
    public int solution(string str1, string str2) {
        int answer = 1;
        int index = str1.IndexOf(str2);
        if(index == -1)
        {
            answer = 2;
        }
        return answer;
    }
}