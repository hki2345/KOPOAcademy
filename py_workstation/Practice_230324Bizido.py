import random
from math import *

bizidoSize = 2000
bizidoList = list(range(bizidoSize))

gunzipCount = 19
gunzipInitPointList = list(range(gunzipCount))

for i in range(len(bizidoList)):
    bizidoList[i] = [random.randrange(0, 100), random.randrange(0, 100)]

for i in range(len(gunzipInitPointList)):
    gunzipInitPointList[i] = [random.randrange(0, 100), random.randrange(0, 100)]


def PointDistance(P1, P2):
    return(sqrt((P2[0] - P1[0]) ** 2 + (P2[1] - P1[1]) ** 2))


def GunzipToIndex(distancelist):
    return distancelist.index(min(distancelist))

# 대충 잡고 보장
gunzipPointList = list(range(gunzipCount))
gunzipAvgPointList = list(range(gunzipCount))

# 2차원 좌표
for i in range(len(gunzipPointList)):
    gunzipPointList[i] = [range(2)]

# 군집된거 가까운 데로 정리
def JungLee():
    for i in range(gunzipCount):
        gunzipPointList[i].clear()

    for i in range(len(bizidoList)):

        distanceList = []
        
        for j in range(gunzipCount):
            distanceList.append(PointDistance(bizidoList[i], gunzipInitPointList[j]))

        Index = GunzipToIndex(distanceList)
        gunzipPointList[Index].append(bizidoList[i])
        distanceList.clear()

def CheckAvgVsPrev():
    for i in range(len(gunzipAvgPointList)):
        if(gunzipInitPointList[i] == gunzipAvgPointList[i]):
            continue
        else:
            for i in range(len(gunzipAvgPointList)):
                gunzipAvgPointList[i] = gunzipInitPointList[i]

            return False
        
    return True

def gunzipReset():
    for i in range(len(gunzipInitPointList)):
        gunzipInitPointList[i] = PyungGyun(i, gunzipPointList)

        

# 군집된 거 평균
def PyungGyun(index, list):

    sumX = 0
    sumY = 0

    for i in range(len(list[index])):
        sumX += list[index][i][0]
        sumY += list[index][i][1]

    if(len(list[index]) != 0):
        return [(int)(sumX / len(list[index])), (int)(sumY / len(list[index]))]
    else:
        return [0, 0]

while not CheckAvgVsPrev():
    JungLee()
    gunzipReset()
    print(gunzipAvgPointList)



import matplotlib.pyplot as plt
plt.figure(figsize=(7, 7))

x = [i[0] for i in gunzipAvgPointList]
y = [i[1] for i in gunzipAvgPointList]
for i in range(gunzipCount):
    X = [j[0] for j in gunzipPointList[i]]
    Y = [j[1] for j in gunzipPointList[i]]
    plt.scatter(X, Y, s=60, alpha=0.5)

plt.scatter(x, y, s=100, alpha=1)
plt.show()