# Итоговая проверочная работа.
студент: Александр Криворучко      
[репозиторий с итоговой работой]( https://github.com/AleksandrKrivoruchko/homework.git)

*email:* <aleksandrkrivorucko74@gmail.com>

---

## Задание

1. Создать репозиторий GitHub.
2. Нарисовать блок-схему алгоритма.
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md).
4. Написать программу, решающую поставленную задачу.
5. Использовать контроль версий в работе над этим небольшим проектом.

***Задача:***

---
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
> Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

---

## Выполнение задания

1. **[Ссылка на репозиторий с выполненым заданием](https://github.com/AleksandrKrivoruchko/homework.git)**
2. Блок-схема алгоритма в файле finalVerificationWork.dio
    + Буду благодарен за рекомендации и найденные ошибки.
3. Данный файл.
4. В программе массив задан на старте. Для решения задачи, создано пространство имен finalVerirficationWork, содержащее публичный класс GamesWithArray. В классе созданы три статических метода. 
    + Метод CountingElNewArray принимает в качестве параметра исходный массив и возвращает количество элементов содержащих 3 и менее символов.
    + Метод CreatingNewArray принимает исходный массив и количество элементов нового массива.
    Объявляет новый массив и инциализирует его строками, содержащими менее 4 символов, из исходного массива. Возвращает новый массив.
    + Метод ConvertArrayToString принимает массив и возвращает его в виде строки отформатированной для вывода на консоль.
    
    В программе объявляем целочисленную переменную len инициализируем ее результатом вызова CountingElNewArray с исходным массивом (sourceArray) в качестве параметра.
    Далее проверяем количество элементов равно нулю? Если да то выводим на консоль [ ], и завершаем программу с кодом завершения 1. Если нет, объявляем строчный массив tempArray и инициализируем его вызовом CreatingNewArray с параметрами sourceArray и len. Затем объявляем строчную переменную sourceStr и инициализируем её вызовом ConvertArrayToString с параметром sourceArray. Объявляем строковую переменную resultStr и инициализируем вызовом ConvertArrayToString с параметром tempArray.
    Полученные результаты выводим на консоль.
    
    **Результат работы програмы:**

    [ "hello", "2", "world", ":)-", "run", "for", "your", "job" ] -> [ "2", ":)-", "run", "for", "job" ]

5. [Результат на GitHub](https://github.com/AleksandrKrivoruchko/homework.git "ссылка на GitHub")

