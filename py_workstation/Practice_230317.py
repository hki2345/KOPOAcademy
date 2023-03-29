# 1
sum = 0
for i in range(100, 1001):
    sum += i

print(sum)


# 2
def size(x1, x2, y1, y2):
    return abs(((x2 - x1) * (y1)) + ((x2 - x1) * (y2 - y1) / 2))

x1 = 2
x2 = 10
print(size(x1, x2, 2 * x1, 2 * x2))


# 3
sum = 0
for i in range(3, 11):
    sum += abs(i ** 2)

print(sum)


# 4
def size(x1, x2, y1, y2):
    return (y2 - y1) / ((x2 - x1))

x1 = 2
x2 = 3
print(size(x1, x2, x1 * 2, x2 * 2))
print(size(x1, x2, x1 ** 2, x2 ** 2))


# 5 람다
s1 = lambda x: x**2
s2 = lambda x, y: x + y
s3 = lambda : "Hello World"
s4 = lambda s: s[::-1].upper()

print(s1(10))
print(s2(10,5))
print(s3())
print(s4("school"))
#s4 = lambda s:s[::-1][::-1][1:3].upper()


# 6 람다 예제
def Im_func(x, fn):
    return fn(x)

print(Im_func(5, lambda x:x**2)) # 25
print(Im_func('School', lambda x:x[2:]*2)) # 'hoolhool'

def fn(x):
    return x[2:]*2

print(Im_func('School', fn)) # 'hoolhool'


#7 map 함수
a = [2.5, 3.8, 4.5, 1.3]

for i in range(len(a)):
    a[i] = int(a[i])

print(a)
print(list(map(int, a)))
print(set(map(int, a)))
print(tuple(map(int, a)))

def func(x):
    return int (x)

print(list(map(func, a)))


# 8 enumerate
a = [2.5, 3.8, 4.5, 1.3]

for i, s in enumerate(a):
    a[i] = int(s)
    print(i,s)

print(a)


for i in enumerate(a):
    print(i, type(i))
    a[i[0]] = int(i[1]) # (0, 2.5)

print(a)


# 9 문제 (2, 3) (5, 6)
import math
print(math.sqrt((5-2)**2 + (6-3)**2))