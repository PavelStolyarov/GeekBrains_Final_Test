# GeekBrains_Final_Test

## Данный проект предназначен для решения задачи на создание нового массива строк включающий в себя строки из исходного массива строк.

### Шаги решения задачи

* Объявляем исходный массив строк **mass** с длинной которая задаётся пользователем с клавиатуры.
* Заполняем исходным массив строками вводимыми с клавиатуры при помощи функции *EnterMassive*.
* Выводим исходный массив при помощи функции *PrintArray*.
* Объявляем переменную **shortCount** для подсчёта строк, удовлетворяющих условию для вхождения в новый массив, в исходном массиве.
* Присваиваем значение переменной **shortCount** при помощи функции *CountShortStrings*, в которой каждый элемент исходного массива проверяется, для выяснения, какие элементы данного массива могут быть переданы в новый массив.
* Призываем функцию *NewMassive* передавая исходный массив и переменную **shortCount**.
* В данной функции вводим новый массив **NewMass** длина которого будет определятся при помощи переменной **shortCount**.
* Также вводим новую переменную **lengthCount** которая будет контролировать количество элементов в новом массиве, чтобы не было переполнения массива.
* При помощи цикла for осуществляем заполнение нового массива строками не превышающими размера в 3 символа.
* Передаём новый заполненый массив в функцию *PrintArray* для вывода в консоль.

## Задача решена!