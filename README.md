### Описание решения


1. string[] first_arr = { "1234", "123", "1567", "-2", "computer science", "new" };

    > Вводим массив строк **"first_arr"** из **6** элементов.

2. string[] second_arr = first_arr.Where(e => e.Length < 4).ToArray();

    > Объявляем новый массив строк **"second_arr"**
    в который, будем помещать каждый элемент **"е"** из первого массива **"first_arr"**,  если он будет удовлеворять(Where) нашему условию **"e.Length < 4"** (длина элемента меньше 4).

3. Console.WriteLine(String.Join(' ', second_arr));
    > Выводим получившийся массив **"second_arr"** в консоль.