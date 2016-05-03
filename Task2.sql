/*
Есть таблица хранящая покупки (строки чека):

Sales: salesid, productid, datetime, customerid.

Мы хотим понять, через какие продукты клиенты «попадают» к нам в магазин. Напишите запрос, который выводит продукт и количество случаев, когда он был первой покупкой клиента.
*/

select s1.productId, count(*)
from sales s1
where s1.DateTime = (select min(s2.datetime) from sales s2 where s2.customerId = s1.CustomerId)
group by s1.ProductId
