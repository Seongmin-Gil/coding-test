using System;

public class Solution {
    public int solution(int[] array, int height) {
        int answer = 0;
        Array.Sort(array);
        foreach(int el in array) {
            if(el > height) {
                answer ++;
            }
        }
        return answer;
    }
}