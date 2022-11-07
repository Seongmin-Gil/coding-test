using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(int[] food) {
        string answer = "";
        List<int> foodList = new List<int>();
        List<int> foodElementList = new List<int>();
        foodList = food.ToList();
        for(int i = 1; i < foodList.Count; i++) {
            int amount = foodList[i]/2;
            for(int j = 0; j < amount; j++) {
                foodElementList.Add(i);
            }
        }
        answer = String.Join("", foodElementList);
        answer += "0";
        foodElementList.Reverse();
        answer += String.Join("",foodElementList);
        
        return answer;
    }
}