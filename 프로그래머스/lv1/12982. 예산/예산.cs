using System;

public class Solution {
    public int solution(int[] d, int budget) {
        int answer = 0;
        int total = 0;
        Array.Sort(d);
        foreach(int el in d) {
            total += el;
            if (total > budget) {
                break;
            }
            answer += 1;
        }
        return answer;
    }
}