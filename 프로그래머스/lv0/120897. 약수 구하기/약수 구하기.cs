using System;

public class Solution {
    public int[] solution(int n) {
        int[] answer = new int[] {};
        int temp = 0;
        for(int i = 1; i <= n; i++)
        {
            if(n % i == 0)
            {
                Array.Resize(ref answer, answer.Length + 1);
                answer[answer.Length - 1] = i;
            }
        }
        return answer;
    }
}