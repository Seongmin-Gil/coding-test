using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string letter) {
        string answer = "";
        string[] arr = letter.Split(" ");
        var morse = new Dictionary<string, string>() {
            {".-", "a"}, {"-...", "b"}, {"-.-.", "c"}, {"-..", "d"}, {".", "e"}, {"..-.", "f"}, 
            {"--.", "g"}, {"....", "h"}, {"..", "i"}, {".---", "j"}, {"-.-", "k"}, {".-..", "l"},
            {"--", "m"}, {"-.", "n"}, {"---", "o"}, {".--.", "p"}, {"--.-", "q"}, {".-.", "r"},
            {"...", "s"}, {"-", "t"}, {"..-", "u"}, {"...-", "v"}, {".--", "w"}, {"-..-", "x"},
            {"-.--", "y"}, {"--..", "z"}
        };
        for(int i = 0 ; i < arr.Length; i ++) {
            answer += morse[arr[i]];
        }
        return answer;
    }
}