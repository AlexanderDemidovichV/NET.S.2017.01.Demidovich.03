# NET.S.2017.01.Demidovich.03
Task1:

Дан массив целых чисел. Найти в массиве и вернуть такой индекс n, для которого сумма элементов слева от него равно сумме элементов справа. Если такого индекса нет вернуть null   или -1.

Например.

>*Для массива {1,2,3,4,3,2,1} функция вернет индекс 3, поскольку на 3-й
позиции массива, суммы слева от индекса ({1,2,3}) и справа от индекса ({3,2, 1})
 равны 6.
 
>*Для массива {1,100,50, -51,1,1} функция вернет индекс 1, поскольку на 1-й 
позиции массива, суммы слева от индекса ({1}) и справа от индекса ({50, -51,1,1 }) 
равны 1.

Входные данные: Целочисленный массив длины 0 <length <1000. Числа в массиве могут быть любым целыми положительными или отрицательными.

Выходные данные: Наименьший индекс, для которого сторона слева равна стороне справа. Если такого индекса не существует вернуть -1(null).

Task2:

Для двух строк, включающих только символы от 'a'  до  'z', вернуть конкатенированную отсортированную по алфавиту строку, исключая повторяющиеся символы.

Например.

>* a = "xyaabbbccccdefww"
>* b = "xxxxyyyyabklmopq"

>* Longest(a, b) -> "abcdefklmopqwxy"

>* a = "abcdefghijklmnopqrstuvwxyz"

>* Longest(a, a) -> "abcdefghijklmnopqrstuvwxyz

Task3:

Даны два целых знаковых четырехбайтовых числа и две позиции битов i и j (i<j). Реализовать алгоритм вставки одного числа в другое так, чтобы второе число занимало позицию с бита j по бит i (биты нумеруются справа налево).

Например.

>* Insertion(8,15,0,0) ->9

>* Insertion(0, 15, 30, 30) ->1073741824

>* Insertion(0, 15, 0, 30) -> 15

>* Insertion(15, -15, 0, 4) -> 31

>* Insertion(15, int.MaxValue, 3, 5)->63
