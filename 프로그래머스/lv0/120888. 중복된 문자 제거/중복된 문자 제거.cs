using System;
using System.Linq;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        char[] arr = my_string.ToCharArray();
        char[] newArr = arr.Distinct().ToArray();
        
        return new String(newArr);
    }
}