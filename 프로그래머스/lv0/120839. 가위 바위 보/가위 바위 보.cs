using System;

public class Solution {
    public string solution(string rsp) {
        string answer = "";
        string[] rspArray = new string[] {"2", "0", "5"};
        string[] winArray = new string[] {"0", "5", "2"};
        for(int i = 0; i < rsp.Length; i ++) {
            int index = Array.IndexOf(rspArray, rsp[i].ToString());
            answer += winArray[index];
        }
        return answer;
    }
}