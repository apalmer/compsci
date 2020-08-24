#import time

#startTime = time.time()

max = 10000000
sum = 0
for i in range(1, max):
    if i%3==0 or i%5==0:
        sum += i
print(sum)

#endTime = time.time()

#executionTime = (endTime - startTime)

print(str(sum))
#print('Execution time in seconds: ' + str(executionTime))