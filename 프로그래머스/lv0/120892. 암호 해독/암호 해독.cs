using System;

public class Solution {
    public string solution(string cipher, int code) {
        string answer = "";
        int count = 0;
        for(int i = 0; i < cipher.Length; i ++)
        {
            count ++;
            if(code == count)
            {
                answer += cipher[i];
                count = 0;
            }
        }
        return answer;
    }
}