using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        Array.Sort(numbers);
        int maxIndex = numbers.Length -1;
        answer = numbers[maxIndex -1] * numbers[maxIndex];
        return answer;
    }
}