import threading as td
import time



class Robot:
    def __init__(self) -> None:
        self.assemble = False

class Person:
    def __init__(self) -> None:
        self.workstatus = False
        self.PredictWorkTime = 0
        self.nowWorkTime = 0
        self.robotName = ""
        self.name = ""

    def SetWork(self, name):
        self.nowWorkTime = 0
        self.workstatus = True
        self.robotName = name
        print(f"{self.name}(이)가 [{self.robotName}]의 작업을 시작합니다.")

    def SetBreak(self):
        self.workRobotName = ""
        self.workstatus = False
        self.nowWorkTime = 0
        

    def Working(self):
        if self.workstatus == False:
            return False

        self.nowWorkTime += 1
        print(f"{self.name}(이)가 [{self.robotName}] 작업 중: {self.nowWorkTime}/{self.PredictWorkTime} 진행 중...")

        if self.PredictWorkTime <= self.nowWorkTime:
            print(f"{self.name}(이)가 [{self.robotName}]의 작업을 완료했습니다.")
            return True

    def isWorkDone(self):
        if not self.workstatus: 
            return True
        else:
            return False

class Major(Person):
    def __init__(self) -> None:
        super().__init__()
        self.name = "고급기술자"
        self.PredictWorkTime = 2

class Senior(Person):
    def __init__(self) -> None:
        super().__init__()
        self.name = "중급기술자"
        self.PredictWorkTime = 5

class Minor(Person):
    def __init__(self) -> None:
        super().__init__()
        self.name = "초급기술자"
        self.PredictWorkTime = 10

robotList = dict()
for i in range(100):
    robotList[str(i+1).zfill(4)] = Robot()

major = Major()
senior = Senior()
minor = Minor()

def factory():
    while True:
        time.sleep(1)
        isDone = False

        if major.Working():
            robotList[major.robotName].assemble = True
            major.SetBreak()
            
        if senior.Working():
            robotList[senior.robotName].assemble = True
            senior.SetBreak()

        if minor.Working():
            robotList[minor.robotName].assemble = True
            minor.SetBreak()

        
        for i in robotList.values():
            if i.assemble == True:
                isDone = True

            elif i.assemble == False:
                isDone = False
                break
            

        if isDone:
            print("모든 작업이 종료했습니다.")
            break
        
        for key, value in robotList.items():
            if value.assemble == False: 
                if major.isWorkDone():
                    major.SetWork(key)

                elif senior.isWorkDone():
                    senior.SetWork(key)

                elif minor.isWorkDone():
                    minor.SetWork(key)

        if isDone: break



        


factoryThread = td.Thread(target=factory)
factoryThread.start()