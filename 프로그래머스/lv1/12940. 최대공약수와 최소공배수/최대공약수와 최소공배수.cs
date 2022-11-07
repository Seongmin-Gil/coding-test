public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[] {};
        int maxNum = n > m ? n : m;
        int minNum = n < m ? n : m;
        
        while ( true ) {
            int a = maxNum % minNum;
            maxNum = minNum;
            
            if(a == 0) {
                break;
            }
            minNum = a;
                
        }
        
        answer = new int[] {minNum, n*m/minNum};
        return answer;
    }
}