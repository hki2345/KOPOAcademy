import threading as td
import random as rd
import time


class computer():
    def __init__(self) -> None:
        self.status = False

    def actionComputer(self):
        self.status = not self.status
        print(f"작동: 컴퓨터, 상태: {self.status}")

class Airconditioner():
    def __init__(self) -> None:
        self.status = False

    def actionAirCon(self):
        self.status = not self.status
        print(f"작동: 에어컨, 상태: {self.status}")

class Window():
    def __init__(self) -> None:
        self.status = False

    def actionWindow(self):
        self.status = not self.status
        print(f"작동: 창문, 상태: {self.status}")

class Door():
    def __init__(self) -> None:
        self.status = False

    def actionDoor(self):
        self.status = not self.status
        print(f"작동: 문, 상태: {self.status}")

class Office:
    def __init__(self) -> None:
        self.computer = computer()
        self.airCon = Airconditioner()
        self.window = Window()
        self.door = Door()





def action():
    dxOffice = Office()
    
    while True:
        randomAct = rd.randint(0, 3)

        if randomAct == 0: dxOffice.airCon.actionAirCon()
        elif randomAct == 1: dxOffice.computer.actionComputer()
        elif randomAct == 2: dxOffice.window.actionWindow()
        elif randomAct == 3: dxOffice.door.actionDoor()
        time.sleep(1)

officeThread = td.Thread(target=action)
officeThread.start()