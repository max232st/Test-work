# Итоговая проверочная работа.
## Задача : 
### Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
## Описание решения:
1. Объявляем два массива: **array** и **newArray**.
2. Создаем метод **FillArray** и с помощью цикла перебираем элементы массива удовлетворяющие условию  "длина строки меньше или равна 3 символам" и заполняем массив **newArray** , 
3. Создаем метод **PrintArray** для вывода массива в консоль.
4. Выводим в сонсоль с помощью **PrintArray** начальный массив **array** и **newArray**