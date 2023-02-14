using System;

public class Solution {
    public int solution(int num, int k) {
        string nums = num.ToString();
        for(int i = 0; i < nums.Length; i++)
        {
            if(int.Parse(nums[i].ToString()) == k)
            {
                return i+1;
            }
        }
        return -1;
    }
}