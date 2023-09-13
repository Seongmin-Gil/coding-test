a = int(input());

b = a//4;

if a % 4 != 0 :
    b += 1
    
word = "long "
print(word * b + "int")