using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string my_string, int n) {
        string answer = "";
        List<string> list = new List<string>();
        for(int i = 0; i < my_string.Length; i++) {
            list.Add(new String(my_string[i], n));
        }
        answer = String.Join("", list.ToArray());
        return answer;
    }
}