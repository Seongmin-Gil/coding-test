using System;

public class Solution {
    public int solution(int price) {
        float answer = 0f;
        if(price >= 500000) {
            answer = price * 0.8f;
        } else if (price >= 300000) {
            answer = price * 0.9f;
        } else if (price >= 100000) {
            answer = price * 0.95f;
        } else {
            return price;
        }
        return (int)Math.Floor(answer);
    }
}