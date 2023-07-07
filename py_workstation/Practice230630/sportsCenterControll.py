import random as rd
import threading

class Person:
    def __init__(self) -> None:
        self.ID = 0
        self.age = rd.randint(10, 100)
 
        self.use1 = 0
        self.use2 = 0
        self.use3 = 0

    def golf(self):
        self.use1 +=1
    def run(self):
        self.use2 +=1
    def swim(self):
        self.use3 +=1



members = [Person() for i in range(0, 100)]

aIdx = 0
sIdx = 0
for i in members:
    if i.age < 20:
        i.ID = 'a' + str(aIdx + 1).zfill(4)
        aIdx += 1

        
    elif i.age >= 20:
        i.ID = 's' + str(sIdx + 1).zfill(4)
        sIdx += 1



def inSports():
    threadIdx = 0
    reportlist = []

    while True: 
        threadIdx += 1
        userIdx = 0
        isMany = ""

        ## 최신화
        for i in members:
            act = rd.randint(0, 1)

            if act == 1:
                sport = rd.randint(0, 2)
                userIdx += 1

                if  sport == 0: i.golf()
                elif sport == 1: i.run()
                elif sport == 2: i.swim()

        if userIdx > 50:
            isMany = "고객 많음"
        elif userIdx <= 50:
            isMany = "고객 적음"

        print(f"{threadIdx}. [이용자 수: {userIdx}, {isMany}]")
        reportlist += [f"{threadIdx}. [이용자 수: {userIdx}, {isMany}]\n"]

        if threadIdx >= 20:
            break

    
    with open("output/report.txt", "w", encoding="utf-8") as f:
        for i in reportlist:
            f.write(i)


sportT = threading.Thread(target=inSports)
sportT.start()
