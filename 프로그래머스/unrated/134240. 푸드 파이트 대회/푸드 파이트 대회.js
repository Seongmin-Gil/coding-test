function solution(food) {
    var answer = '';
    const left = [];
    
    for (let i = 1; i <= food.length; i ++) {
        left.push((i+"").repeat(food[i]/2))
    }
    let word = left.join("") + "0";
    const right = left.reverse()
    word += right.join("")        
    return word;
}