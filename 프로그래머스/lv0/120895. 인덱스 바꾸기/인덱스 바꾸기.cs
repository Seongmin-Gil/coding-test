using System;

public class Solution {
    public string solution(string my_string, int num1, int num2) {
        string answer = "";
        char[] array = my_string.ToCharArray();
        char temp = array[num1];
        array[num1] = array[num2];
        array[num2] = temp;
        answer = string.Concat(array);
        return answer;
    }
}