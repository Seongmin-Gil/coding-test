using System;

public class Solution {
    public int[] solution(int[] numbers) {
        int[] answer = new int[numbers.Length];
        int index = 0;
        foreach(int num in numbers) {
            answer[index] = num * 2;
            index ++;
        }
        return answer;
    }
}