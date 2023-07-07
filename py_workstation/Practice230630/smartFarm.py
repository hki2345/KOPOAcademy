import threading as td
import random as rd
import time

temper = 0
water = 0

lock = td.Lock()

def setTemper():
    global temper
    while True:
        lock.acquire()
        temper = rd.randint(0, 100)
        lock.release()
        print(f"온도가 재설정되었습니다: {temper}도\n")
        time.sleep(10)

def setWater():
    global water
    while True:
        lock.acquire()
        water = rd.randint(0, 100)
        lock.release()
        print(f"습도가 재설정되었습니다: {water}도\n")
        time.sleep(10)

class Product:
    def __init__(self) -> None:
        self.status = False
        self.name = "unknown"

    def turnOn(self):
        if self.status == False:
            self.status = True
            print(f"{self.name}(이)가 작동됩니다.")

    def turnOff(self):
        if self.status == True:
            self.status = False
            print(f"{self.name}(이)가 꺼집니다.")

    def Acting(self):
        if self.status == True:
            print(f"[온도: {temper}][습도: {water}] {self.name} 가동 중... ")


class Heater(Product):
    def __init__(self) -> None:
        super().__init__()
        self.name = "온풍기"
    
    def Acting(self):
        super().Acting()
        global temper
        if self.status: 
            lock.acquire()
            temper += 1
            lock.release()

class AirConditioner(Product):
    def __init__(self) -> None:
        super().__init__()
        self.name = "에어컨"
    
    def Acting(self):
        super().Acting()
        global temper
        if self.status: 
            lock.acquire()
            temper -= 1
            lock.release()
            


class Humidifier(Product):
    def __init__(self) -> None:
        super().__init__()
        self.name = "가습기"
    
    def Acting(self):
        super().Acting()
        global water
        if self.status: 
            lock.acquire()
            water += 1
            lock.release()

class Dehumidifier(Product):
    def __init__(self) -> None:
        super().__init__()
        self.name = "제습기"
    
    def Acting(self):
        super().Acting()
        global water
        if self.status: 
            lock.acquire()
            water -= 1
            lock.release()



tpThread = td.Thread(target=setTemper)
wtThread = td.Thread(target=setWater)

tpThread.start()
wtThread.start()

heater = Heater()
aircon = AirConditioner()
humidifier = Humidifier()
dehumidifier = Dehumidifier()

while True:
    time.sleep(1)

    heater.Acting()
    aircon.Acting()
    humidifier.Acting()
    dehumidifier.Acting()

    if temper < 20: 
        heater.turnOn() 
        aircon.turnOff()

    elif temper >= 25: 
        heater.turnOff() 
        aircon.turnOn()
    
    if water < 40: 
        humidifier.turnOn() 
        dehumidifier.turnOff()

    elif water >= 60: 
        humidifier.turnOff() 
        dehumidifier.turnOn()