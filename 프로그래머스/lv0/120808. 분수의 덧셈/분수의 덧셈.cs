using System;

public class Solution {
    public int[] solution(int denum1, int num1, int denum2, int num2) {
        int[] answer = new int[2];
        answer[0] = denum1 * num2 + denum2 * num1;
        answer[1] = num1 * num2;
        int max = answer[0];
        int maxNum = 0;
        for(int i =1; i <= max; i ++) {
            if(answer[0] % i == 0 && answer[1] % i == 0) {
                maxNum = i;
            }
        }
        answer[0] = answer[0] / maxNum;
        answer[1] = answer[1] / maxNum;
        
        return answer;
    }
}