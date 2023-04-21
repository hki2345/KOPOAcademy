import random as rd
import numpy as np
import cv2 as cv


mPlayerCount = 50
class Player:
    def __init__(self) -> None:
        self.coin = 10
        self.diceCount = 2
        self.score = 0
        self.nowScore = 0

playerList = list()
for i in range(mPlayerCount):
    playerList.append(Player())

def CheckGameisOver():
    for i in playerList:
        if i.score >= 1000:
            return False
        
    return True

## 점수값과 같은지 여부를 판별함
def ThrowDice(user):
    scoreList = list()
    for i in range(user.diceCount):
        scoreList.append(rd.randint(1, 6))

    sum = 0
    for i in scoreList:
        sum += i

    isSame = False
    isSameDict = {}
    for i in scoreList:
        try: isSameDict[i] += 1
        except: isSameDict[i] = 1

    
    if 1 == len(isSameDict):
        isSame =True
    else:
        isSame = False

    return sum, isSame

def CheckDiceScore():
    scoreList = list()

    for i in playerList:
        scoreList.append(i.nowScore)
    
    maxValue = max(scoreList)
    minValue = min(scoreList)

    for i in playerList:
        if i.nowScore == maxValue:
            i.nowScore *= 2
        elif i.nowScore == minValue:
            i.nowScore -= 30

def SetDiceScore():
    for i in playerList:
        i.score += i.nowScore
        i.nowScore = 0

def CheckCoin(user):
    if user.coin <= 0:
        user.coin = rd.randint(1, 10)
        return False
    
    return True


def PrintBox():
    width = 1024
    height = 350
    depth =3

    thickness = -1
    offset_x = 1
    offset_y = 4
    x = 1
    y = 6
    screen_start_x = 10
    screen_start_y = 300
    bgr = (0, 255, 0)

    img = np.zeros(shape = (height, width, depth)) # img = npzeros((height, width, depth), np.uint8)

    for i in range(1000):

        for j in range(mPlayerCount):
            if i >= playerList[j].score:
                continue
            
            start_x = screen_start_x + i * x
            start_y = screen_start_y - j * y
            cv.rectangle(img, (start_x, start_y), (start_x + offset_x, start_y + offset_y), bgr, thickness)

    cv.imshow("test", img)
    cv.waitKey(100)

while(CheckGameisOver()):
    for i in playerList:
        ## 코인이 읎다.
        if not CheckCoin(i):
            continue

        ## 코인이 있당
        i.coin -= 1
        diceScore = 0
        result = ThrowDice(i)
        diceScore += result[0]

        ## 한 번만 더 한다.
        if result[1] == True:
            result = ThrowDice(i)
            diceScore += result[0]

        i.nowScore = diceScore

    CheckDiceScore()
    SetDiceScore()
    PrintBox()





