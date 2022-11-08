using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] words = s.Split(' ');
        for(int i = 0; i<words.Length; i ++) {
            for(int j = 0; j <words[i].Length; j++) {
                if(j % 2 == 0) {
                    answer += Char.ToUpper(words[i][j]);
                } else {
                    answer += Char.ToLower(words[i][j]);
                }
            }
            if (i < words.Length -1 ) {
                answer += " ";
            }
        }
        return answer;
    }
}