--select
select ContactName,CompanyName,City from Customers

select * from Customers where City = 'London'

select * from Products where CategoryID=1 or CategoryID=3
select * from Products where CategoryID=1 and UnitPrice>=10
--order by ... ya göre sırala demek
select * from Products order by CategoryID,ProductName
select * from Products order by UnitPrice desc   --ascending asc = artan -- descending desc= azalan
select * from Products where CategoryID=1 order by UnitPrice desc
-- tek bir kolon tek bir sayı count ile
select count(*) from Products 
--Adet dediğimiz yer alias(isim) oluyor.
select count(*)Adet from Products 
-- Hangi kategoride kaç tane ürün var?
select CategoryId,count(*) Adet from Products group by CategoryID
-- Hangi kategorilerde ürün sayısı 10 dan az olan kategorileri listele
select CategoryId,count(*) Adet from Products group by CategoryID having count(*)<10

select * 
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID

--DTO Data Transformation object

select * from Customers c left join Orders o
on c.CustomerID= o.CustomerID
where o.CustomerID is null

