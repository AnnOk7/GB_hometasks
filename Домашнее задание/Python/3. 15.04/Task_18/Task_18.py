#  Требуется найти в массиве A[1..N] самый близкий 
# по величине элемент к заданному числу X. Пользователь 
# в первой строке вводит натуральное число N – количество
# элементов в массиве. В последующих  строках записаны
# N целых чисел Ai. Последняя строка содержит число X


import random

N = int(input("Введите размер массива: "))
X = int(input("Введите число Х: "))
A = []
for i in range(N):
    A.append(random.randrange(N))
print(A)
def nearval(A, X):
    return min(A, key=lambda x: X - x) 
print(f'Ближайшее к {X} число в массиве: {nearval(A, X)}')