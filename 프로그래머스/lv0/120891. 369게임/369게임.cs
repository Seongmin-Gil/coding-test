using System;

public class Solution {
    public int solution(int order) {
        int answer = 0;
        string words = order.ToString();
        for(int i = 0; i < words.Length; i++)
        {
            int num = int.Parse(words[i].ToString());
            if(num % 3 == 0 && num != 0) {
                answer ++;
            }
        }
        return answer;
    }
}