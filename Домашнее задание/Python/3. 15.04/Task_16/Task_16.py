# Требуется вычислить, сколько раз встречается некоторое число X
# в массиве A[1..N]. Пользователь в первой строке вводит 
# натуральное число N – количество элементов в массиве. 
# В последующих  строках записаны N целых чисел Ai. 
# Последняя строка содержит число X

N = int(input("Введите размер списка: "))
A = list(range(1, N+1))

X = int(input("Введите число, количество которого нужно посчитать: "))
count = A.count(X)
print("В списке", A , "число", X , "встречается", count , "раз")