using System;

public class Solution {
    public long solution(string numbers) {
        long answer = 0;
        string[] words = new string[10] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        for(int i = 0; i < words.Length; i++)
        {
            numbers = numbers.Replace(words[i], i.ToString());
        }
        answer = long.Parse(numbers);
        return answer;
    }
}