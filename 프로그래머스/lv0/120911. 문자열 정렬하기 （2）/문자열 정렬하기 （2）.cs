using System;
using System.Linq;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        answer = String.Concat(my_string.ToLower().OrderBy(el => el)); 
        return answer;
    }
}