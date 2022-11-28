using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] numbers, string direction) {
        int[] answer = new int[numbers.Length];
        int[] arr1 = new int[1];
        if(direction == "right") {
            arr1[0] = numbers[numbers.Length -1];
            int[] arr2 = numbers.Where((num, index) => index != numbers.Length -1).ToArray();
            answer = arr1.Concat(arr2).ToArray();
        } else {
            arr1[0] = numbers[0];
            answer = numbers.Where((num, index) => index != 0).ToArray().Concat(arr1).ToArray();
        }
        
        return answer;
    }
}