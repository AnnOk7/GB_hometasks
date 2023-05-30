# Дополнить телефонный справочник возможностью изменения и удаления данных.
# Пользователь также может ввести имя или фамилию, и Вы должны реализовать 
# функционал для изменения и удаления данных

def readfile(data):
    data = [i.split() for i in open('phones.txt', 'r', encoding='utf-8')]
    return data

def printinfo(data):
    for i in data:
        print(i)

def findinfo(data):
    with open('phones.txt', 'r', encoding='utf-8') as data:
        book = data.read().split('\n')
        temp = input('Чей номер ищем?: ')
        for i in book:
            if temp in i:
                print(i)

import os
def remove(data):
   with open('phones.txt', 'r', encoding='utf-8') as data:
       book = data.read().split('\n')
       temp = input('Чей номер удаляем?: ')
       with open('phones.txt', 'w', encoding='utf-8') as data:
           for i in book:
               if temp.strip("\n") != temp:
                   data.write(i)
                       

def export(data):
    with open('phones.txt', 'a', encoding='utf-8') as data:
        data.writelines(input('Введите новую строку: '+' \n'))
        data.write("\n")

def main():
    my_choice = -1
    data = readfile('phones.txt')
    while my_choice != 0 :
        print('Выберите действие:')
        print('1 - Вывести инфо на экран')
        print('2 - Произвести экспорт данных')
        print('3 - Удалить данные из списка')
        print('4 - Поиск данных из списка')
        print('0 - Выход из программы')
        my_choice = int(input())
        operations = {1: printinfo, 2: export, 3: remove, 4: findinfo}
        operations[my_choice](data)
        if my_choice == 1:
            printinfo(data)
     
    print('До свидания')

if __name__ == '__main__':
    main()

