function solution(left, right) {
    var answer = 0;
    for (let i = left ; i <= right; i++) {
        let num = counter(i)
        answer = num % 2 === 0 ? answer + i : answer - i
    }
    return answer;
}

const counter = (num) => {
    let count = 0;
    for (let i = 1; i <= num; i ++) {
        if(num % i === 0) count ++
    }
    return count
}