import matplotlib.pyplot as plt
import random

for i in range(100):
    f = open(f"output/histogram/{i + 1}.txt", "w")
    for j in range(10):
        d = random.randint(1,100)
        f.write(f"{d},")
    f.close()


metaData = dict()


for i in range(100):
    with open(f"output/histogram/{i + 1}.txt") as f:
        data = f.read().split(',')
        ## 마지막 요소가 반점으로 공백처리됌
        data.pop()
        metaData[i + 1] = data

i30idx = 0
metalist = []
for i in metaData.values():
    for j in i:
        metalist.append(int(j))
        if j == "30":
            i30idx += 1

print(f"숫자 30의 개수: {i30idx}")

metalist.sort()
print(set(metalist))                        
plt.hist(metalist)
plt.show()
