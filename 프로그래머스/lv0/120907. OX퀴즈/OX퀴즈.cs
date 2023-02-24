using System;

public class Solution {
    public string[] solution(string[] quiz) {
        string[] answer = new string[quiz.Length];

        for(int i=0; i<quiz.Length; i++)
        {
            string[] input = quiz[i].Split(' ');

            int a = int.Parse(input[0]);
            int b = int.Parse(input[2]);
            int c = int.Parse(input[4]);

            switch(input[1])
            {
                case "+":
                    if (a + b == c)
                        answer[i] = "O";
                    else
                        answer[i] = "X";
                    break;

                case "-":
                    if (a - b == c)
                        answer[i] = "O";
                    else
                        answer[i] = "X";
                    break;
            }
        }
        return answer;
    }
}