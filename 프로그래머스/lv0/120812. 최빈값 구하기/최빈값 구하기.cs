using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        int maxArray = 0;
        foreach(int num in array) {
            if(maxArray < num) maxArray = num;
        }
        
        int[] count = new int[maxArray+1];
        int max = 0;
        for(int i = 0; i < array.Length; i ++) {
            count[array[i]] ++;
        }
        for(int i = 0; i < count.Length; i ++) {
            if(count[i] > max) {
                answer = i;
                max = count[i];
            } else if(count[i] == max) {
                answer = -1;
            }
        }
        return answer;
    }
}