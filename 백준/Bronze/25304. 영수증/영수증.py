totalPrice = int(input());
total = int(input());

nowPrice = 0;

for i in range(total) :
    a, b = map(int, input().split());
    nowPrice += a * b;
    
if nowPrice == totalPrice :
    print("Yes")
else : 
    print("No")