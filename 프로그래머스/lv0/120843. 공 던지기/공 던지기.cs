using System;

public class Solution {
    public int solution(int[] numbers, int k) {
        int answer = 0;
        int count = 1;
        int index = 0;
        while(count < k) {
            index += 2;
            count ++;
            if(index > numbers.Length) {
                index = index - numbers.Length;
            }
            if(count == k) {
                answer = numbers[index];
                break;
            }
        }
        return answer;
    }
}