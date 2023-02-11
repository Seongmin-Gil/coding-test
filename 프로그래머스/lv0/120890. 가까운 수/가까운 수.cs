using System;

public class Solution {
    public int solution(int[] array, int n) {
        int answer = 0;
        int[] diffs = new int[array.Length];
        Array.Sort(array);
        for(int i = 0; i < array.Length; i++)
        {
            int diff = n - array[i];
            diffs[i] = diff > 0 ? diff : diff * -1;
            if(i == 0)
            {
                answer = array[i];
            } else if (i != 0 && diffs[i] < diffs[i-1])
            {
                answer = array[i];
            }
        }
        
        return answer;
    }
}