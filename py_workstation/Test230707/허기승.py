import random as rd

class Train:
    def __init__(self, id) -> None:
        self.people = 0
        self.maxPeople = 10
        self.ID = id

    def isBoard(self):
        return self.people < self.maxPeople

class People:
    def __init__(self, id) -> None:
        self.age = rd.randint(10, 100)
        self.ID = id
        self.TrainID = 0
        self.shallBoard = False

trainList = [Train(i) for i in range(1, 6)]
peopleList = [People('s' + str(i)) for i in range(1, 101)]


for p in peopleList:
    isOnBoard = rd.randint(0, 1)

    ## 탄다
    if isOnBoard == 0:
        targetTrainNum = rd.randint(1, 5)
        p.shallBoard = True

        ## 대상열차에 올라탄다.
        if trainList[targetTrainNum - 1].isBoard():
            trainList[targetTrainNum - 1].people += 1
            p.TrainID = trainList[targetTrainNum - 1].ID

        ## 정원초과
        else:
            p.TrainID = -1

    ## 안탄다
    elif isOnBoard == 1:
        p.shallBoard = False


## 출력
for p in peopleList:
    if p.shallBoard == False and p.TrainID == 0:
        p.TrainID = "없음"

    if p.TrainID == -1:
        p.TrainID = "실패"


    print(f"ID: {p.ID}\t탑승의사: {p.shallBoard}\t탑승열차ID: {p.TrainID}")