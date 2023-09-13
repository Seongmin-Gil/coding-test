num = int(input());
numArray = list(map(int, input().split()));
a = int(input());
count = 0;
for i in range(num) :
    if a == numArray[i] : 
        count += 1;
        
print(count);