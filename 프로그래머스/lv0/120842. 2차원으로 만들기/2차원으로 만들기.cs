using System;

public class Solution {
    public int[,] solution(int[] num_list, int n) {
        int[,] answer = new int[num_list.Length / n, n];
        int count = 0;
        int index = 0;
        for(int i = 0; i < num_list.Length; i ++) {
            answer[index, count] = num_list[i];
            count ++;
            if(count == n ) {
                index ++;
                count = 0;
            }
        }
        return answer;
    }
}