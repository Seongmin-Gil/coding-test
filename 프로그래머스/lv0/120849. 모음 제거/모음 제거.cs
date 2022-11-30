using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        char[] alpha = new char[5] {'a', 'e', 'i', 'o', 'u'};
        for(int i = 0; i < my_string.Length; i++) {
            if( Array.IndexOf(alpha, my_string[i]) == -1) {
                answer += my_string[i];
            }
        }
        return answer;
    }
}