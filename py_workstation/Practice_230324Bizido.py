import random
from math import *

bizidoSize = 100
bizidoList = list(range(bizidoSize))

gunzipCount = 3
gunzipInitPointList = list(range(gunzipCount))

for i in range(len(bizidoList)):
    bizidoList[i] = [random.randrange(0, 100), random.randrange(0, 100)]

for i in range(len(gunzipInitPointList)):
    gunzipInitPointList[i] = [random.randrange(0, 100), random.randrange(0, 100)]


def PointDistance(P1, P2):
    return(sqrt((P2[0] - P1[0]) ** 2 + (P2[1] - P1[1]) ** 2))


def GunzipToIndex(d1, d2, d3):
    if(d1 < d2):
        if(d1 < d3):
            return 0
        else:
            return 2

    else:
        if(d2 < d3):
            return 1
        else:
            return 2

# 대충 잡고 보장
gunzipPointList = list(range(gunzipCount))

# 2차원 좌표
for i in range(len(gunzipPointList)):
    gunzipPointList[i] = [range(2)]


for i in range(len(bizidoList)):
    d1 = PointDistance(bizidoList[i], gunzipInitPointList[0])
    d2 = PointDistance(bizidoList[i], gunzipInitPointList[1])
    d3 = PointDistance(bizidoList[i], gunzipInitPointList[2])

    Index = GunzipToIndex(d1, d2, d3)
    gunzipPointList[Index].append(bizidoList[i])


def PyungGyun(list):

    sumX = 0
    sumY = 0

    for i in range(len(list[0])):
        sumX += list[0, i]
        sumY += list[0, i]

    return [sumX / len(list[0]), sumY / len(list[0])]

print(gunzipPointList)
print(PyungGyun(gunzipPointList))
