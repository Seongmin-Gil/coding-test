using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        string nums = n.ToString();
        for(int i = 0; i < nums.Length; i ++)
        {
            answer += int.Parse(nums[i].ToString());
        }
        return answer;
    }
}