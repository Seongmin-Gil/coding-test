using System;
using System.Text.RegularExpressions;

public class Solution {
    public int[] solution(string my_string) {
        char[] numArray = Regex.Replace(my_string, @"\D", "").ToCharArray();
        int[] answer = new int[numArray.Length];
        for(int i = 0; i < numArray.Length; i++) {
            answer[i] = numArray[i] -'0';
        }
        Array.Sort(answer);
        return answer;
    }
}