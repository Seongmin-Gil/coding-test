using System;
using System.Text.RegularExpressions;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        string strNum = Regex.Replace(my_string, @"\D", "");
        foreach(char num in strNum) {
            answer += (int)Char.GetNumericValue(num);
        }
        return answer;
    }
}