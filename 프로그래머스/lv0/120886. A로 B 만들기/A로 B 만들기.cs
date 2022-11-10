using System;

public class Solution {
    public int solution(string before, string after) {
        int answer = 1;
        char[] arr = before.ToCharArray();
        foreach(char str in arr) {
            int index = after.IndexOf(str);
            if(index > -1) {
               after = after.Remove(index, 1);
            } else {
                return 0;
            }
        }
        return answer ;
    }
}