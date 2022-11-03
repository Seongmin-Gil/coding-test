function solution(s) {
    var answer = false;
    const regex = /\d/gm
    if(s.replace(regex, "").length === 0 && (s.length === 4 ||s.length === 6)) return true
    return answer;
}