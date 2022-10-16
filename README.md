# *Задание контрольной работы*

> Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

# *Описание решения контрольной работы*
1. Первоначальный массив задается в начале выполнения программы.
2. Первоначальный массив выводится в терминале с помощью метода PrintArray.
3. Выполнение основного задания происходит с помощью метода NewArrayLessThreeSymbols:
    + Вычисление размера нового массива.
        * Ввод переменной newLength = 0;
        * Проверка элементов первоначального массива на предмет их размера с помощью if;
        * При нахождении каждого элемента меньше 3 символов переменная newLength увеличивается на 1;
    + Заполнение нового массива элементами.
        * Ввод нового результирующего массива string[] result = new string[newLength];
        * Ввод переменной count = 0;
        * С помощью цикла for и условия if gроверка элементов первоначального массива на предмет их размера;
        * При нахождении каждого элемента меньше 3 символов элементу массива result[count] присваивается значение элемента массива array[i];
        * Метод возвращает результирующий массив result.
4. Результирующий массив result выводится в терминале с помощью метода PrintArray.