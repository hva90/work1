#Вопрос 1

Вы собираетесь совершить долгое путешествие через множество населенных пунктов. Чтобы не запутаться, вы сделали карточки вашего путешествия. Каждая карточка содержит в себе пункт отправления и пункт назначения.

Гарантируется, что если упорядочить эти карточки так, чтобы для каждой карточки в упорядоченном списке пункт назначения на ней совпадал с пунктом отправления в следующей карточке в списке, получится один список карточек без циклов и пропусков.

Например, у нас есть карточки

Мельбурн → Кельн

Москва → Париж

Кельн → Москва

Если упорядочить их в соответствии с требованиями выше, то получится следующий список:

Мельбурн → Кельн, Кельн → Москва, Москва → Париж



Требуется:

Написать функцию, которая принимает набор неупорядоченных карточек и возвращает набор упорядоченных карточек в соответствии с требованиями выше, то есть в возвращаемом из функции списке карточек для каждой карточки пункт назначения на ней должен совпадать с пунктом отправления на следующей карточке.

Дать оценку сложности получившегося алгоритма сортировки

Написать тесты

Оценивается правильность работы, производительность и читабельность кода

Результат:
Сложность алгоритма O(n2)
https://github.com/hva90/work1/tree/master/Task1

#Вопрос 2

Есть таблица хранящая покупки (строки чека):

Sales: salesid, productid, datetime, customerid.

Мы хотим понять, через какие продукты клиенты «попадают» к нам в магазин. Напишите запрос, который выводит продукт и количество случаев, когда он был первой покупкой клиента.

Результат:
https://github.com/hva90/work1/blob/master/Task2.sql
