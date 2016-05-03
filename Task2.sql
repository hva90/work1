/*
���� ������� �������� ������� (������ ����):

Sales: salesid, productid, datetime, customerid.

�� ����� ������, ����� ����� �������� ������� ��������� � ��� � �������. �������� ������, ������� ������� ������� � ���������� �������, ����� �� ��� ������ �������� �������.
*/

select s1.productId, count(*)
from sales s1
where s1.DateTime = (select min(s2.datetime) from sales s2 where s2.customerId = s1.CustomerId)
group by s1.ProductId
