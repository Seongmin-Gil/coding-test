using System;

public class Solution {
    public int[] solution(int n, int[] numlist) {
        int[] answer = new int[] {};
        for(int i = 0; i < numlist.Length; i ++)
        {
            if( numlist[i] % n == 0)
            {
                Array.Resize(ref answer, answer.Length + 1);
                answer[answer.Length - 1] = numlist[i];
            }
        }
        return answer;
    }
}