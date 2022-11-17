using System;

public class Solution {
    public string solution(string my_string, string letter) {
        string answer = "";
        string[] arr = my_string.Split(letter);
        return String.Join("", arr);
    }
}