using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        string[] nums = my_string.Split(' ');
        answer = int.Parse(nums[0]);
        for(int i = 1; i < nums.Length; i ++)
        {
            if(i % 2 != 0 && nums[i] == "+")
            {
                answer += int.Parse(nums[i+1]);
            } else if(i % 2 != 0 && nums[i] == "-")
            {
                answer -= int.Parse(nums[i+1]);
            } 
        }
        return answer;
    }
}